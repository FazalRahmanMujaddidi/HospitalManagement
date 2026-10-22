
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class MedicineBatch
    {
        [Key]
        public int MedicineBatchId { get; set; }

        public int MedicineId { get; set; }

        [Required]
        [StringLength(100)]
        public string BatchNumber { get; set; }
            = string.Empty;

        public DateOnly ExpiryDate { get; set; }

        [Range(typeof(decimal), "0.001", "999999999")]
        public decimal QuantityReceived { get; set; }

        [Range(typeof(decimal), "0", "999999999")]
        public decimal QuantityRemaining { get; set; }

        [Range(typeof(decimal), "0", "999999999")]
        public decimal PurchasePrice { get; set; }

        public DateTime ReceivedAt { get; set; }
            = DateTime.UtcNow;

        // Relationship
        public Medicine Medicine { get; set; } = null!;
    }
}
