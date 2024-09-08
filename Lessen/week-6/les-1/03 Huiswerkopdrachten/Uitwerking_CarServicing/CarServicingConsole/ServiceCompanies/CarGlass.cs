using CarServicingConsole.Vehicles;

namespace CarServicingConsole.ServiceCompanies
{
    public class CarGlass
    {
        public void PerformGlassService(Car car) 
        {
            car.MaintenanceBooklet.AddEntry($"Window(s) fixed and polished by {nameof(CarGlass)}");
        }
    }
}
