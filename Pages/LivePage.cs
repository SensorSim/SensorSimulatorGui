using System.ComponentModel;
using Microsoft.AspNetCore.SignalR.Client;
using SensorSimulatorGui.Api;
using SensorSimulatorGui.Dto;

namespace SensorSimulatorGui.Pages;

public partial class LivePage : UserControl
{
    private ReactorApiClient? _api;
    private HubConnection? _hub;

    private readonly BindingList<MeasurementOut> _items = new();

    public LivePage()
    {
        InitializeComponent();

        dgvLive.AutoGenerateColumns = true;
        dgvLive.DataSource = _items;

        btnClearFilter.Click += (_, _) => txtFilterSensorId.Text = string.Empty;
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

            var hubUrl = _api.ControllerBaseUrl.TrimEnd('/') + "/hub/measurements";

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

            _hub.On<MeasurementOut>("measurement", m =>
            {
                var filter = txtFilterSensorId.Text.Trim();
                if (!string.IsNullOrWhiteSpace(filter) &&
                    !string.Equals(filter, m.SensorId, StringComparison.OrdinalIgnoreCase))
                    return;

                SafeUi(() =>
                {
                    _items.Insert(0, m);
                    while (_items.Count > 500) _items.RemoveAt(_items.Count - 1);
                });
            });

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
