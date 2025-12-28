namespace SensorSimulatorGui.Dto;

public sealed record MeasurementOut(
    string SensorId,
    DateTimeOffset Timestamp,
    double Value);

public sealed class PagedResponse<T>
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int Total { get; set; }

    // API wraps the list in an { items: [...] } envelope.
    public List<T> Items { get; set; } = new();
}
