using System.ComponentModel;
using SensorSimulatorGui.Api;
using SensorSimulatorGui.Dto;

namespace SensorSimulatorGui.Pages;

public partial class ArchivedPage : UserControl
{
    private ReactorApiClient? _api;
    private readonly BindingList<MeasurementOut> _items = new();

    public ArchivedPage()
    {
        InitializeComponent();

        dgvArchived.AutoGenerateColumns = true;
        dgvArchived.DataSource = _items;

        btnLoad.Click += async (_, _) => await LoadAsync();
    }

    public void SetApi(ReactorApiClient api) => _api = api;

    public async Task LoadAsync()
    {
        if (_api is null) return;

        try
        {
            lblStatus.Text = "Loading...";

            var sensorId = txtSensorId.Text.Trim();
            if (string.IsNullOrWhiteSpace(sensorId)) sensorId = null;

            DateTimeOffset? from = dtFrom.Checked ? new DateTimeOffset(dtFrom.Value) : null;
            DateTimeOffset? to = dtTo.Checked ? new DateTimeOffset(dtTo.Value) : null;

            var page = (int)numPage.Value;

            var result = await _api.GetMeasurementsAsync(sensorId, from, to, page: page, pageSize: 200);

            _items.Clear();
            foreach (var m in result.Items)
                _items.Add(m);

            lblStatus.Text = $"Page {result.Page} – items {result.Items.Count} / total {result.Total}";
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"Error: {ex.Message}";
        }
    }
}
