namespace SensorSimulatorGui
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var settings = Config.SettingsLoader.Load();
            Application.Run(new Form1(settings));
        }
    }
}
