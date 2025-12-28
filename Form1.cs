using SensorSimulatorGui.Api;
using SensorSimulatorGui.Pages;

namespace SensorSimulatorGui;

public partial class Form1 : Form
{
    private readonly HttpClient _http;
    private readonly ReactorApiClient _api;

    private readonly SensorsPage _sensorsPage;
    private readonly LivePage _livePage;
    private readonly ArchivedPage _archivedPage;

    public Form1()
    {
        InitializeComponent();

        Text = "Reactor Monitor – GUI Prototype";

        _http = new HttpClient();
        _api = new ReactorApiClient(_http);

        txtSensorManagerUrl.Text = _api.SensorManagerBaseUrl;
        txtArchiverUrl.Text = _api.ArchiverBaseUrl;
        txtControllerUrl.Text = _api.ControllerBaseUrl;

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

        btnApplyUrls.Click += async (_, _) =>
        {
            ApplyUrlsFromTextBoxes();
            await _livePage.ConnectAsync(forceReconnect: true);
            await _sensorsPage.RefreshAsync();
        };

        btnReconnectLive.Click += async (_, _) =>
        {
            ApplyUrlsFromTextBoxes();
            await _livePage.ConnectAsync(forceReconnect: true);
        };

        btnNavSensors.Click += async (_, _) =>
        {
            ShowPage(_sensorsPage);
            await _sensorsPage.RefreshAsync();
        };

        btnNavLive.Click += (_, _) => ShowPage(_livePage);

        btnNavArchived.Click += (_, _) => ShowPage(_archivedPage);

        Shown += async (_, _) =>
        {
            ApplyUrlsFromTextBoxes();
            await _livePage.ConnectAsync();
            await _sensorsPage.RefreshAsync();
        };
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);
        try { _livePage.DisconnectAsync().GetAwaiter().GetResult(); } catch { }
        _http.Dispose();
    }

    private void ApplyUrlsFromTextBoxes()
    {
        _api.SensorManagerBaseUrl = txtSensorManagerUrl.Text.Trim();
        _api.ArchiverBaseUrl = txtArchiverUrl.Text.Trim();
        _api.ControllerBaseUrl = txtControllerUrl.Text.Trim();
    }

    private static void ShowPage(Control page)
    {
        page.BringToFront();
    }
}
