using SensorSimulatorGui.Api;
using SensorSimulatorGui.Config;
using SensorSimulatorGui.Pages;
using System.Drawing;

namespace SensorSimulatorGui;

public partial class Form1 : Form
{
    private readonly HttpClient _http;
    private readonly ReactorApiClient _api;

    private readonly SensorsPage _sensorsPage;
    private readonly LivePage _livePage;
    private readonly ArchivedPage _archivedPage;

    private readonly ReactorMonitorSettings _settings;

    // Nav highlight.
    private readonly Color _navIdle = Color.FromArgb(17, 24, 39);
    private readonly Color _navHover = Color.FromArgb(30, 41, 59);
    private readonly Color _navActive = Color.FromArgb(91, 33, 182); // purple accent
    private readonly Color _navText = Color.FromArgb(226, 232, 240);
    private readonly Color _navTextActive = Color.White;

    // Avoid double-close during async shutdown.
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
        SetActiveNav(btnNavSensors);

        btnNavSensors.Click += async (_, _) =>
        {
            ShowPage(_sensorsPage);
            SetActiveNav(btnNavSensors);
            await _sensorsPage.RefreshAsync();
        };

        btnNavLive.Click += (_, _) =>
        {
            ShowPage(_livePage);
            SetActiveNav(btnNavLive);
        };

        btnNavArchived.Click += (_, _) =>
        {
            ShowPage(_archivedPage);
            SetActiveNav(btnNavArchived);
        };

        Shown += async (_, _) =>
        {
            await _livePage.ConnectAsync();
            await _sensorsPage.RefreshAsync();
        };
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        // Don't block the UI thread on shutdown.
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

            // Finish closing.
            Close();
        });
    }

    private static void ShowPage(Control page)
    {
        page.BringToFront();
    }

    private void SetActiveNav(Button active)
    {
        var buttons = new[] { btnNavSensors, btnNavLive, btnNavArchived };

        foreach (var b in buttons)
        {
            b.BackColor = _navIdle;
            b.ForeColor = _navText;
            b.Font = new Font(b.Font, FontStyle.Regular);
            b.FlatAppearance.MouseOverBackColor = _navHover;
        }

        active.BackColor = _navActive;
        active.ForeColor = _navTextActive;
        active.Font = new Font(active.Font, FontStyle.Bold);
    }
}
