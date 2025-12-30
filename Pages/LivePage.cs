using Microsoft.AspNetCore.SignalR.Client;
using SensorSimulatorGui.Api;
using SensorSimulatorGui.Controls;
using SensorSimulatorGui.Dto;

namespace SensorSimulatorGui.Pages;

public partial class LivePage : UserControl
{
    private ReactorApiClient? _api;
    private HubConnection? _hub;

    // Latest measurement per sensor.
    private readonly Dictionary<string, MeasurementOut> _latest = new(StringComparer.OrdinalIgnoreCase);

    // Cards shown on screen (one per sensor).
    private readonly Dictionary<string, LiveSensorCard> _cards = new(StringComparer.OrdinalIgnoreCase);

    private sealed record SensorMeta(string Unit, LiveSensorCard.Bands Bands);

    // Cached sensor meta for nicer cards (unit + ranges).
    private readonly Dictionary<string, SensorMeta> _metaBySensorId = new(StringComparer.OrdinalIgnoreCase);

    public LivePage()
    {
        InitializeComponent();

        btnClearFilter.Click += (_, _) => txtFilterSensorId.Text = string.Empty;
        btnReconnect.Click += async (_, _) => await ConnectAsync(forceReconnect: true);
        txtFilterSensorId.TextChanged += (_, _) => ApplyFilter();

        // Starts empty.
        lblEmptyHint.Visible = true;
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

            // Pull sensor metadata once so cards can show units.
            await RefreshSensorMetaAsync();

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

            SafeUi(() => lblStatus.Text = "connecting...");
            await _hub.StartAsync();
            SafeUi(() => lblStatus.Text = "connected");

            // Keep one subscription entry in Controller so it's visible in Swagger during demos.
            _ = _api.EnsureSubscriptionAsync(Environment.MachineName, "all");
        }
        catch (Exception ex)
        {
            SafeUi(() => lblStatus.Text = $"error: {ex.Message}");
        }
    }

    private async Task RefreshSensorMetaAsync()
    {
        if (_api is null) return;

        try
        {
            var sensors = await _api.GetSensorsAsync(pageSize: 500);
            _metaBySensorId.Clear();

            foreach (var s in sensors)
            {
                if (string.IsNullOrWhiteSpace(s.SensorId))
                    continue;

                _metaBySensorId[s.SensorId] = new SensorMeta(
                    s.Unit ?? string.Empty,
                    new LiveSensorCard.Bands(s.OperatingMin, s.OperatingMax, s.WarningMin, s.WarningMax));
            }
        }
        catch
        {
            // Not fatal (cards will still work, just without unit labels).
        }
    }

    private void UpsertMeasurement(MeasurementOut m)
    {
        _latest[m.SensorId] = m;

        // Create/update the card.
        if (!_cards.TryGetValue(m.SensorId, out var card))
        {
            card = new LiveSensorCard
            {
                Margin = new Padding(0, 0, 12, 12)
            };
            card.SetSensorId(m.SensorId);

            _cards[m.SensorId] = card;
            AddCardSorted(card);
        }

        _metaBySensorId.TryGetValue(m.SensorId, out var meta);
        card.UpdateFrom(m, meta?.Unit, meta?.Bands);

        lblEmptyHint.Visible = flowCards.Controls.Count == 0;
        ApplyFilter();
    }

    private void AddCardSorted(LiveSensorCard card)
    {
        // Keep it stable-ish: insert alphabetically by SensorId.
        var idx = 0;
        foreach (Control c in flowCards.Controls)
        {
            if (c is LiveSensorCard other)
            {
                if (string.Compare(card.SensorId, other.SensorId, StringComparison.OrdinalIgnoreCase) < 0)
                    break;
            }
            idx++;
        }

        flowCards.Controls.Add(card);
        flowCards.Controls.SetChildIndex(card, idx);
    }

    private void ApplyFilter()
    {
        var filter = txtFilterSensorId.Text.Trim();

        if (string.IsNullOrWhiteSpace(filter))
        {
            foreach (var kv in _cards)
                kv.Value.Visible = true;
            return;
        }

        foreach (var kv in _cards)
        {
            kv.Value.Visible = kv.Key.Contains(filter, StringComparison.OrdinalIgnoreCase);
        }
    }

    public async Task DisconnectAsync()
    {
        if (_hub is null) return;

        // Don't let shutdown hang the whole app on exit.
        var hub = _hub;
        _hub = null;

        try { await WithTimeout(hub.StopAsync(), 1200).ConfigureAwait(false); } catch { }
        try { await WithTimeout(hub.DisposeAsync().AsTask(), 1200).ConfigureAwait(false); } catch { }

        SafeUi(() => lblStatus.Text = "disconnected");
    }

    private static async Task WithTimeout(Task task, int timeoutMs)
    {
        await Task.WhenAny(task, Task.Delay(timeoutMs)).ConfigureAwait(false);
    }

    private void SafeUi(Action action)
    {
        if (IsDisposed) return;
        if (InvokeRequired) BeginInvoke(action);
        else action();
    }
}
