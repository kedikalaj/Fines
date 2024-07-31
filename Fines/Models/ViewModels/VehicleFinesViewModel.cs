namespace Fines.Models.ViewModels
{
    public class VehicleFinesViewModel
    {
        public string LicensePlate { get; set; }
        public List<Fine> Fines { get; set; }
        public decimal TotalUnpaidFines { get; set; }
    }

}
