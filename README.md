# Reactor Monitor GUI (WinForms)

Windows Forms client used for the PRPO GUI requirement.

Pages:

- Sensors: CRUD sensor configuration (SensorManager)
- Live: current value per sensor (SignalR from Controller)
- Archived: query stored measurements (Archiver)

## Branching

- `dev` – development
- `main` – stable / demo-ready

## Requirements

- Windows
- .NET SDK (tested with 10.0.101)

## Run

From the repo root:

```bat
dotnet run --project SensorSimulatorGui\SensorSimulatorGui.csproj
```

## Configuration

Endpoints are read from `appsettings.json`:

```json
{
  "ReactorMonitor": {
    "SensorManagerBaseUrl": "http://localhost:8083",
    "ArchiverBaseUrl": "http://localhost:8081",
    "ControllerBaseUrl": "http://localhost:8082",
    "ControllerHubPath": "/hub/measurements"
  }
}
```

Environment variable overrides are supported:

- `ReactorMonitor__SensorManagerBaseUrl`
- `ReactorMonitor__ArchiverBaseUrl`
- `ReactorMonitor__ControllerBaseUrl`
- `ReactorMonitor__ControllerHubPath`
