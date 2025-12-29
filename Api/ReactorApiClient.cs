using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using SensorSimulatorGui.Dto;

namespace SensorSimulatorGui.Api;

/// <summary>
/// Small REST client used by the WinForms UI.
/// </summary>
public sealed class ReactorApiClient
{
    private readonly HttpClient _http;

    public string SensorManagerBaseUrl { get; set; } = "http://localhost:8083";
    public string ArchiverBaseUrl { get; set; } = "http://localhost:8081";
    public string ControllerBaseUrl { get; set; } = "http://localhost:8082";

    public string ControllerHubPath { get; set; } = "/hub/measurements";

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public ReactorApiClient(HttpClient http)
    {
        _http = http;
        _http.Timeout = TimeSpan.FromSeconds(10);
    }
    // SensorManager
    public async Task<List<SensorDefinitionOut>> GetSensorsAsync(bool? enabled = null, bool? simulate = null, string? sensorType = null, int page = 1, int pageSize = 200, CancellationToken ct = default)
    {
        var url = $"{SensorManagerBaseUrl.TrimEnd('/')}/sensors?page={page}&pageSize={pageSize}";
        if (!string.IsNullOrWhiteSpace(sensorType)) url += $"&sensorType={Uri.EscapeDataString(sensorType)}";
        if (enabled is not null) url += $"&enabled={enabled.Value.ToString().ToLowerInvariant()}";
        if (simulate is not null) url += $"&simulate={simulate.Value.ToString().ToLowerInvariant()}";

        using var res = await _http.GetAsync(url, ct);
        res.EnsureSuccessStatusCode();

        var payload = await res.Content.ReadFromJsonAsync<SensorsListResponse>(JsonOptions, ct);
        return payload?.Items ?? new List<SensorDefinitionOut>();
    }

    public async Task<SensorDefinitionOut> CreateSensorAsync(SensorDefinitionIn input, CancellationToken ct = default)
    {
        var url = $"{SensorManagerBaseUrl.TrimEnd('/')}/sensors";
        using var res = await _http.PostAsJsonAsync(url, input, JsonOptions, ct);

        if (res.StatusCode == HttpStatusCode.Conflict)
        {
            var msg = await res.Content.ReadAsStringAsync(ct);
            throw new InvalidOperationException(msg);
        }

        res.EnsureSuccessStatusCode();

        var created = await res.Content.ReadFromJsonAsync<SensorDefinitionOut>(JsonOptions, ct);
        return created ?? throw new InvalidOperationException("Unexpected empty response from SensorManager.");
    }

    public async Task<SensorDefinitionOut> UpdateSensorAsync(string sensorId, SensorDefinitionIn input, CancellationToken ct = default)
    {
        var url = $"{SensorManagerBaseUrl.TrimEnd('/')}/sensors/{Uri.EscapeDataString(sensorId)}";
        using var res = await _http.PutAsJsonAsync(url, input, JsonOptions, ct);
        res.EnsureSuccessStatusCode();

        var updated = await res.Content.ReadFromJsonAsync<SensorDefinitionOut>(JsonOptions, ct);
        return updated ?? throw new InvalidOperationException("Unexpected empty response from SensorManager.");
    }

    public async Task DeleteSensorAsync(string sensorId, CancellationToken ct = default)
    {
        var url = $"{SensorManagerBaseUrl.TrimEnd('/')}/sensors/by-sensorId/{Uri.EscapeDataString(sensorId)}";
        using var res = await _http.DeleteAsync(url, ct);
        if (res.StatusCode == HttpStatusCode.NotFound)
            return;
        res.EnsureSuccessStatusCode();
    }
    // Archiver
    public async Task<PagedResponse<MeasurementOut>> GetMeasurementsAsync(string? sensorId = null, DateTimeOffset? from = null, DateTimeOffset? to = null, int page = 1, int pageSize = 200, CancellationToken ct = default)
    {
        var url = $"{ArchiverBaseUrl.TrimEnd('/')}/measurements?page={page}&pageSize={pageSize}";
        if (!string.IsNullOrWhiteSpace(sensorId)) url += $"&sensorId={Uri.EscapeDataString(sensorId)}";
        if (from is not null) url += $"&from={Uri.EscapeDataString(from.Value.ToString("O"))}";
        if (to is not null) url += $"&to={Uri.EscapeDataString(to.Value.ToString("O"))}";

        using var res = await _http.GetAsync(url, ct);
        res.EnsureSuccessStatusCode();

        var payload = await res.Content.ReadFromJsonAsync<PagedResponse<MeasurementOut>>(JsonOptions, ct);
        return payload ?? new PagedResponse<MeasurementOut>();
    }
    // Controller (subscriptions)
    public async Task EnsureSubscriptionAsync(string clientId, string filter = "all", CancellationToken ct = default)
    {
        // Controller takes clientId from the route and filter from the query string.
        var url = $"{ControllerBaseUrl.TrimEnd('/')}/subscriptions/{Uri.EscapeDataString(clientId)}?filter={Uri.EscapeDataString(filter)}";
        using var res = await _http.PostAsync(url, content: null, ct);

        // If it's already there, just update it.
        if (res.StatusCode == HttpStatusCode.Conflict || res.StatusCode == HttpStatusCode.BadRequest)
        {
            var putUrl = $"{ControllerBaseUrl.TrimEnd('/')}/subscriptions/{Uri.EscapeDataString(clientId)}?filter={Uri.EscapeDataString(filter)}";
            using var put = await _http.PutAsync(putUrl, content: null, ct);
            _ = put.IsSuccessStatusCode;
            return;
        }

        _ = res.IsSuccessStatusCode;
    }
}
