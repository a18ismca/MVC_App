namespace MyApp.Models
{
    public class Person
    {
        public string SSN { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public List<Vehicle> OwnedVehicles { get; set; } = new List<Vehicle>();
        
        public string VehiclePlate { get; set; }
    }
}
