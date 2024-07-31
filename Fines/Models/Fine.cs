using System.ComponentModel.DataAnnotations.Schema;

namespace Fines.Models
{
    public class Fine
    {
        public int Id { get; set; }
        public DateTime DateOfFine { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Reason { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }

        public int VehicleId { get; set; }

        [ForeignKey("VehicleId")]
        public Vehicle? Vehicle { get; set; }
    }
}
