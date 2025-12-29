using System.ComponentModel;
using SensorSimulatorGui.Api;
using SensorSimulatorGui.Dto;

namespace SensorSimulatorGui.Pages;

public partial class SensorsPage : UserControl
{
    private ReactorApiClient? _api;
    private readonly BindingList<SensorDefinitionOut> _items = new();

    public SensorsPage()
    {
        InitializeComponent();

        dgvSensors.AutoGenerateColumns = true;
        dgvSensors.DataSource = _items;

        dgvSensors.SelectionChanged += (_, _) => PopulateInputsFromSelectedRow();

        btnRefresh.Click += async (_, _) => await RefreshAsync();
        btnAdd.Click += async (_, _) => await AddAsync();
        btnUpdate.Click += async (_, _) => await UpdateAsync();
        btnDelete.Click += async (_, _) => await DeleteAsync();
    }

    public void SetApi(ReactorApiClient api) => _api = api;

    public async Task RefreshAsync()
    {
        if (_api is null) return;
        try
        {
            lblStatus.Text = "Loading sensors...";
            var sensors = await _api.GetSensorsAsync(page: 1, pageSize: 500);

            _items.Clear();
            foreach (var s in sensors)
                _items.Add(s);

            lblStatus.Text = $"Loaded {_items.Count} sensors.";
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"Error: {ex.Message}";
        }
    }

    private async Task AddAsync()
    {
        if (_api is null) return;
        try
        {
            var input = ReadInputs();
            lblStatus.Text = "Adding...";
            _ = await _api.CreateSensorAsync(input);
            lblStatus.Text = "Added.";
            await RefreshAsync();
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"Error: {ex.Message}";
        }
    }

    private async Task UpdateAsync()
    {
        if (_api is null) return;
        try
        {
            var sensorId = txtSensorId.Text.Trim();
            if (string.IsNullOrWhiteSpace(sensorId))
                throw new InvalidOperationException("SensorId is required.");

            var input = ReadInputs();
            lblStatus.Text = "Updating...";
            _ = await _api.UpdateSensorAsync(sensorId, input);
            lblStatus.Text = "Updated.";
            await RefreshAsync();
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"Error: {ex.Message}";
        }
    }

    private async Task DeleteAsync()
    {
        if (_api is null) return;
        try
        {
            var sensorId = txtSensorId.Text.Trim();
            if (string.IsNullOrWhiteSpace(sensorId))
                throw new InvalidOperationException("SensorId is required.");

            lblStatus.Text = "Deleting...";
            await _api.DeleteSensorAsync(sensorId);
            lblStatus.Text = "Deleted.";
            await RefreshAsync();
        }
        catch (Exception ex)
        {
            lblStatus.Text = $"Error: {ex.Message}";
        }
    }

    private SensorDefinitionIn ReadInputs()
    {
        var sensorId = txtSensorId.Text.Trim();
        var sensorType = txtSensorType.Text.Trim();
        var unit = txtUnit.Text.Trim();

        if (string.IsNullOrWhiteSpace(sensorId))
            throw new InvalidOperationException("SensorId is required.");
        if (string.IsNullOrWhiteSpace(sensorType))
            throw new InvalidOperationException("SensorType is required.");
        if (string.IsNullOrWhiteSpace(unit))
            throw new InvalidOperationException("Unit is required.");

        return new SensorDefinitionIn(
            SensorId: sensorId,
            SensorType: sensorType,
            Unit: unit,
            OperatingMin: (double)numOperatingMin.Value,
            OperatingMax: (double)numOperatingMax.Value,
            WarningMin: (double)numWarningMin.Value,
            WarningMax: (double)numWarningMax.Value,
            IntervalMs: (int)numIntervalMs.Value,
            Enabled: chkEnabled.Checked,
            Simulate: chkSimulate.Checked
        );
    }

    private void PopulateInputsFromSelectedRow()
    {
        if (dgvSensors.CurrentRow?.DataBoundItem is not SensorDefinitionOut s)
            return;

        txtSensorId.Text = s.SensorId;
        txtSensorType.Text = s.SensorType;
        txtUnit.Text = s.Unit;
        numOperatingMin.Value = SafeDecimal(s.OperatingMin);
        numOperatingMax.Value = SafeDecimal(s.OperatingMax);
        numWarningMin.Value = SafeDecimal(s.WarningMin);
        numWarningMax.Value = SafeDecimal(s.WarningMax);
        numIntervalMs.Value = Math.Clamp(s.IntervalMs, (int)numIntervalMs.Minimum, (int)numIntervalMs.Maximum);
        chkEnabled.Checked = s.Enabled;
        chkSimulate.Checked = s.Simulate;
    }

    private static decimal SafeDecimal(double value)
    {
        try
        {
            var d = (decimal)value;
            return d;
        }
        catch
        {
            return 0;
        }
    }
}
