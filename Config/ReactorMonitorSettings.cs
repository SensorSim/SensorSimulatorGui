using Microsoft.Extensions.Configuration;

namespace SensorSimulatorGui.Config;

public sealed class ReactorMonitorSettings
{
    public string SensorManagerBaseUrl { get; set; } = "http://localhost:8083";
    public string ArchiverBaseUrl { get; set; } = "http://localhost:8081";
    public string ControllerBaseUrl { get; set; } = "http://localhost:8082";

    /// <summary>
    /// SignalR hub path hosted by the Controller service.
    /// </summary>
    public string ControllerHubPath { get; set; } = "/hub/measurements";

    public override string ToString()
        => $"SensorManager={SensorManagerBaseUrl}, Archiver={ArchiverBaseUrl}, Controller={ControllerBaseUrl}{ControllerHubPath}";
}

public static class SettingsLoader
{
    public static ReactorMonitorSettings Load()
    {
        // Standard pattern: appsettings.json + optional environment-specific + optional local overrides.
        // Environment variables override everything (ReactorMonitor__SensorManagerBaseUrl, ...).
        var environment =
            Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT")
            ?? Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
            ?? "Production";

        var config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true)
            .AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        return config.GetSection("ReactorMonitor").Get<ReactorMonitorSettings>() ?? new ReactorMonitorSettings();
    }
}
