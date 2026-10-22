
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Diagnosis
    {
        [Key]
        public int DiagnosisId { get; set; }

        // Required relationships
        public int EncounterId { get; set; }
        public int DoctorId { get; set; }

        // Optional inpatient admission link
        public int? AdmissionId { get; set; }

        [Required]
        [StringLength(200)]
        public string DiagnosisName { get; set; }
            = string.Empty;

        [StringLength(30)]
        public string? DiagnosisCode { get; set; }

        public string? Notes { get; set; }

        public DateTime DiagnosedAt { get; set; }
            = DateTime.UtcNow;

        // Navigation properties
        public Encounter Encounter { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
        public Admission? Admission { get; set; }
    }
}
