using CarServicingConsole.ServiceCompanies;
using CarServicingConsole.Vehicles;

namespace CarServicingConsole.Services
{
    public class Garage
    {
        public void PerformMaintenance(Car car, CarService windowService)
        {
            car.MaintenanceBooklet.AddEntry("Spark plugs replaced");
            car.MaintenanceBooklet.AddEntry("Engine oil refreshed");

            windowService?.Invoke(car);

            car.MaintenanceBooklet.AddEntry("Interior cleaned");
            car.MaintenanceBooklet.AddEntry("Washed and polished");
        }
    }
}
