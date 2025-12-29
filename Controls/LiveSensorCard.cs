using SensorSimulatorGui.Dto;

namespace SensorSimulatorGui.Controls;

public partial class LiveSensorCard : UserControl
{
    public string SensorId { get; private set; } = string.Empty;

    public readonly record struct Bands(double OperatingMin, double OperatingMax, double WarningMin, double WarningMax);

    public LiveSensorCard()
    {
        InitializeComponent();

        // Keep the control snappy when lots of updates come in.
        SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        UpdateStyles();
    }

    public void SetSensorId(string sensorId)
    {
        SensorId = sensorId;
        lblSensorId.Text = sensorId;
    }

    public void UpdateFrom(MeasurementOut m, string? unit = null, Bands? bands = null)
    {
        if (!string.Equals(SensorId, m.SensorId, StringComparison.OrdinalIgnoreCase))
            SetSensorId(m.SensorId);

        lblValue.Text = FormatValue(m.Value);
        lblUnit.Text = unit ?? string.Empty;

        // Display local time to match what users expect.
        var tsLocal = m.Timestamp.ToLocalTime();
        lblTimestamp.Text = $"Updated {tsLocal:yyyy-MM-dd HH:mm:ss}";

        UpdateIndicator(tsLocal, m.Value, bands);
    }

    private static string FormatValue(double value)
    {
        // Looks nice for both pressure and temperature-ish values.
        return value.ToString("0.##");
    }

    private void UpdateIndicator(DateTimeOffset lastUpdated, double value, Bands? bands)
    {
        // Gray out if the value is stale (helps spot disconnected sensors).
        var age = DateTimeOffset.Now - lastUpdated;
        if (age.TotalSeconds >= 15)
        {
            pnlIndicator.BackColor = System.Drawing.Color.FromArgb(160, 160, 160);
            return;
        }

        // Otherwise, color by value band if we have sensor config.
        if (bands is null)
        {
            pnlIndicator.BackColor = age.TotalSeconds < 5
                ? System.Drawing.Color.FromArgb(60, 179, 113)
                : System.Drawing.Color.FromArgb(255, 165, 0);
            return;
        }

        var b = bands.Value;
        // OK: inside operating range
        if (value >= b.OperatingMin && value <= b.OperatingMax)
        {
            pnlIndicator.BackColor = System.Drawing.Color.FromArgb(60, 179, 113);
            return;
        }

        // Warning: outside operating but still inside warning band
        if (value >= b.WarningMin && value <= b.WarningMax)
        {
            pnlIndicator.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            return;
        }

        // Alarm: outside warning band
        pnlIndicator.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
    }
}
