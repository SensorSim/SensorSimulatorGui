using SensorSimulatorGui.Api;
using SensorSimulatorGui.Config;
using SensorSimulatorGui.Pages;

namespace SensorSimulatorGui;

public partial class Form1 : Form
{
    private readonly HttpClient _http;
    private readonly ReactorApiClient _api;

    private readonly SensorsPage _sensorsPage;
    private readonly LivePage _livePage;
    private readonly ArchivedPage _archivedPage;

    private readonly ReactorMonitorSettings _settings;

    private bool _isClosing;

    public Form1(ReactorMonitorSettings settings)
    {
        InitializeComponent();

        Text = "Reactor Monitor – GUI";

        _settings = settings;

        _http = new HttpClient();
        _api = new ReactorApiClient(_http);

        _api.SensorManagerBaseUrl = _settings.SensorManagerBaseUrl;
        _api.ArchiverBaseUrl = _settings.ArchiverBaseUrl;
        _api.ControllerBaseUrl = _settings.ControllerBaseUrl;
        _api.ControllerHubPath = _settings.ControllerHubPath;

        lblEndpoints.Text = $"SM: {_api.SensorManagerBaseUrl} | Archiver: {_api.ArchiverBaseUrl} | Controller: {_api.ControllerBaseUrl}{_api.ControllerHubPath}";

        _sensorsPage = new SensorsPage { Dock = DockStyle.Fill };
        _livePage = new LivePage { Dock = DockStyle.Fill };
        _archivedPage = new ArchivedPage { Dock = DockStyle.Fill };

        _sensorsPage.SetApi(_api);
        _livePage.SetApi(_api);
        _archivedPage.SetApi(_api);

        panelContent.Controls.Add(_sensorsPage);
        panelContent.Controls.Add(_livePage);
        panelContent.Controls.Add(_archivedPage);

        ShowPage(_sensorsPage);

        btnNavSensors.Click += async (_, _) =>
        {
            ShowPage(_sensorsPage);
            await _sensorsPage.RefreshAsync();
        };

        btnNavLive.Click += (_, _) => ShowPage(_livePage);

        btnNavArchived.Click += (_, _) => ShowPage(_archivedPage);

        Shown += async (_, _) =>
        {
            await _livePage.ConnectAsync();
            await _sensorsPage.RefreshAsync();
        };
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        // Don't block the UI thread here (waiting on async tasks can deadlock WinForms).
        if (_isClosing)
        {
            base.OnFormClosing(e);
            return;
        }

        _isClosing = true;
        e.Cancel = true;

        Enabled = false;

        BeginInvoke(async () =>
        {
            try { await _livePage.DisconnectAsync(); } catch { }
            try { _http.Dispose(); } catch { }

            // Trigger the actual close now that async shutdown is done.
            Close();
        });
    }

    private static void ShowPage(Control page)
    {
        page.BringToFront();
    }
}
