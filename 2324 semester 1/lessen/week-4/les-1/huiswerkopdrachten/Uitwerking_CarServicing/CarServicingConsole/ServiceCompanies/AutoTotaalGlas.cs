using CarServicingConsole.Vehicles;

namespace CarServicingConsole.Services
{
    public class AutoTotaalGlas
    {
        public void PerformTotalGlassService(Car car)
        {
            car.MaintenanceBooklet.AddEntry($"Window(s) totally repaired by {nameof(AutoTotaalGlas)}");
        }
    }
}
