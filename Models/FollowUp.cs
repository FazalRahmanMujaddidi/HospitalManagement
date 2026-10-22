
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class FollowUp
    {
        [Key]
        public int FollowUpId { get; set; }

        public int PatientId { get; set; }
        public int EncounterId { get; set; }

        // Null until a follow-up appointment is booked
        public int? AppointmentId { get; set; }

        public DateTime RecommendedDate { get; set; }

        [StringLength(1000)]
        public string? Instructions { get; set; }

        [Required]
        [StringLength(30)]
        public string Status { get; set; } = "Recommended";
        // Recommended, Scheduled, Completed,
        // Declined, Cancelled

        // Relationships
        public Patient Patient { get; set; } = null!;
        public Encounter Encounter { get; set; } = null!;
        public Appointment? Appointment { get; set; }
    }
}
