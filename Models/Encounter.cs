
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Encounter
    {
        [Key]
        public int EncounterId { get; set; }

        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        // Null for walk-in visits
        public int? AppointmentId { get; set; }

        public DateTime VisitDate { get; set; }
            = DateTime.UtcNow;

        [Required]
        [StringLength(30)]
        public string VisitType { get; set; } = "Outpatient";
        // Outpatient or WalkIn

        [StringLength(500)]
        public string? ChiefComplaint { get; set; }

        public string? ExaminationNotes { get; set; }

        [Required]
        [StringLength(30)]
        public string Status { get; set; } = "InProgress";
        // InProgress, Completed, Cancelled

        public DateTime? CompletedAt { get; set; }

        // Navigation properties
        public Patient Patient { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
        public Appointment? Appointment { get; set; }

        public ICollection<Diagnosis> Diagnoses
            { get; set; } = new List<Diagnosis>();

        public ICollection<Prescription> Prescriptions
            { get; set; } = new List<Prescription>();

        public ICollection<FollowUp> FollowUps
            { get; set; } = new List<FollowUp>();
    }
}
