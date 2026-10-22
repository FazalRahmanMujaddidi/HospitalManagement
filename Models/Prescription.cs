
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Prescription
    {
        [Key]
        public int PrescriptionId { get; set; }

        public int EncounterId { get; set; }
        public int DoctorId { get; set; }

        public DateTime PrescribedAt { get; set; }
            = DateTime.UtcNow;

        [Required]
        [StringLength(30)]
        public string Status { get; set; } = "Issued";
        // Draft, Issued, Cancelled

        public string? Notes { get; set; }

        // Relationships
        public Encounter Encounter { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;

        public ICollection<PrescriptionItem> Items
            { get; set; } = new List<PrescriptionItem>();
    }
}
