namespace CarServicingConsole.Vehicles
{

    public class Car
    {
        public string Make { get; set; }
        public Booklet MaintenanceBooklet { get; }

        public Car(string make)
        {
            Make = make;
            MaintenanceBooklet = new Booklet($"{Make} maintenance");
        }

    }
}
