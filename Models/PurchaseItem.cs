
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
    public class PurchaseItem
    {
        public int PurchaseItemId { get; set; }

        public int PurchaseId { get; set; }
        public int MedicineId { get; set; }

        [Precision(18, 2)]
        public decimal QuantityOrdered { get; set; }

        [Precision(18, 2)]
        public decimal QuantityReceived { get; set; } = 0;

        [Precision(18, 2)]
        public decimal UnitPurchasePrice { get; set; }

        // Optional discount amount for this entire line
        [Precision(18, 2)]
        public decimal DiscountAmount { get; set; } = 0;

        // Navigation properties
        public Purchase Purchase { get; set; } = null!;
        public Medicine Medicine { get; set; } = null!;
    }
}
