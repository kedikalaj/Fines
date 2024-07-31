namespace Fines.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public List<Fine>? Fines { get; set; }
    }
}
