using CarServicingConsole.ServiceCompanies;
using CarServicingConsole.Services;
using CarServicingConsole.Vehicles;


var garage = new Garage();

var mercedes = new Car("Mercedes");
var carGlass = new CarGlass();
garage.PerformMaintenance(mercedes, carGlass.PerformGlassService);
Console.WriteLine(mercedes.MaintenanceBooklet.Content);


var volvo = new Car("Volvo");
var autoTotaalGlas = new AutoTotaalGlas();
garage.PerformMaintenance(volvo, autoTotaalGlas.PerformTotalGlassService);
Console.WriteLine(volvo.MaintenanceBooklet.Content);


Console.WriteLine("\nPress <ENTER> to exit..");
Console.ReadLine();

