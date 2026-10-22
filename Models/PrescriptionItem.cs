
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class PrescriptionItem
    {
        [Key]
        public int PrescriptionItemId { get; set; }

        public int PrescriptionId { get; set; }
        public int MedicineId { get; set; }

        [Required]
        [StringLength(50)]
        public string Dose { get; set; } = string.Empty;

        [StringLength(30)]
        public string? DoseUnit { get; set; }

        [StringLength(50)]
        public string? Route { get; set; }

        [StringLength(100)]
        public string? Frequency { get; set; }

        public int? DurationDays { get; set; }

        public string? Instructions { get; set; }

        // Relationships
        public Prescription Prescription { get; set; } = null!;
        public Medicine Medicine { get; set; } = null!;
    }
}
