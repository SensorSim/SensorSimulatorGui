namespace SensorSimulatorGui.Dto;

public sealed record SensorDefinitionIn(
    string SensorId,
    string SensorType,
    string Unit,
    double OperatingMin,
    double OperatingMax,
    double WarningMin,
    double WarningMax,
    int IntervalMs,
    bool Enabled,
    bool Simulate);

public sealed record SensorDefinitionOut(
    Guid Id,
    string SensorId,
    string SensorType,
    string Unit,
    double OperatingMin,
    double OperatingMax,
    double WarningMin,
    double WarningMax,
    int IntervalMs,
    bool Enabled,
    bool Simulate,
    DateTimeOffset UpdatedAt);

public sealed class SensorsListResponse
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int Total { get; set; }

    // API returns { items: [...] }.
    public List<SensorDefinitionOut> Items { get; set; } = new();
}
