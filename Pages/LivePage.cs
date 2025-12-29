using System.ComponentModel;
using System.Linq;
using Microsoft.AspNetCore.SignalR.Client;
using SensorSimulatorGui.Api;
using SensorSimulatorGui.Dto;

namespace SensorSimulatorGui.Pages;

public partial class LivePage : UserControl
{
    private ReactorApiClient? _api;
    private HubConnection? _hub;

    // Latest measurement per sensor.
    private readonly Dictionary<string, MeasurementOut> _latest = new(StringComparer.OrdinalIgnoreCase);

    // What we actually show in the grid (either all sensors, or a filtered subset).
    private readonly BindingList<MeasurementOut> _items = new();
    private readonly Dictionary<string, int> _viewIndexBySensorId = new(StringComparer.OrdinalIgnoreCase);

    public LivePage()
    {
        InitializeComponent();

        dgvLive.AutoGenerateColumns = false;
        dgvLive.DataSource = _items;

        btnClearFilter.Click += (_, _) => txtFilterSensorId.Text = string.Empty;
        btnReconnect.Click += async (_, _) => await ConnectAsync(forceReconnect: true);

        txtFilterSensorId.TextChanged += (_, _) => ApplyFilter();
    }

    public void SetApi(ReactorApiClient api) => _api = api;

    public async Task ConnectAsync(bool forceReconnect = false)
    {
        if (_api is null) return;

        try
        {
            if (_hub is not null && !forceReconnect)
            {
                lblStatus.Text = _hub.State.ToString();
                return;
            }

            await DisconnectAsync();

            var hubUrl = _api.ControllerBaseUrl.TrimEnd('/') + _api.ControllerHubPath;

            _hub = new HubConnectionBuilder()
                .WithUrl(hubUrl)
                .WithAutomaticReconnect()
                .Build();

            _hub.Reconnecting += _ =>
            {
                SafeUi(() => lblStatus.Text = "reconnecting...");
                return Task.CompletedTask;
            };
            _hub.Reconnected += _ =>
            {
                SafeUi(() => lblStatus.Text = "connected");
                return Task.CompletedTask;
            };
            _hub.Closed += _ =>
            {
                SafeUi(() => lblStatus.Text = "disconnected");
                return Task.CompletedTask;
            };

            _hub.On<MeasurementOut>("measurement", m => SafeUi(() => UpsertMeasurement(m)));

            lblStatus.Text = "connecting...";
            await _hub.StartAsync();
            lblStatus.Text = "connected";

            // Keep one subscription entry in Controller so it's visible in Swagger during demos.
            _ = _api.EnsureSubscriptionAsync(Environment.MachineName, "all");
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"error: {ex.Message}";
        }
    }

    private void UpsertMeasurement(MeasurementOut m)
    {
        _latest[m.SensorId] = m;

        var filter = txtFilterSensorId.Text.Trim();
        if (!string.IsNullOrWhiteSpace(filter) &&
            !string.Equals(filter, m.SensorId, StringComparison.OrdinalIgnoreCase))
            return;

        UpsertInView(m);
    }

    private void ApplyFilter()
    {
        var filter = txtFilterSensorId.Text.Trim();

        _items.Clear();
        _viewIndexBySensorId.Clear();

        if (string.IsNullOrWhiteSpace(filter))
        {
            foreach (var m in _latest.Values.OrderBy(x => x.SensorId, StringComparer.OrdinalIgnoreCase))
                UpsertInView(m);
        }
        else if (_latest.TryGetValue(filter, out var one))
        {
            UpsertInView(one);
        }
    }

    private void UpsertInView(MeasurementOut m)
    {
        if (_viewIndexBySensorId.TryGetValue(m.SensorId, out var idx))
        {
            _items[idx] = m;
            return;
        }

        _items.Add(m);
        _viewIndexBySensorId[m.SensorId] = _items.Count - 1;
    }

    public async Task DisconnectAsync()
    {
        if (_hub is null) return;

        try { await _hub.StopAsync(); } catch { }
        try { await _hub.DisposeAsync(); } catch { }
        _hub = null;

        SafeUi(() => lblStatus.Text = "disconnected");
    }

    private void SafeUi(Action action)
    {
        if (IsDisposed) return;
        if (InvokeRequired) BeginInvoke(action);
        else action();
    }
}
