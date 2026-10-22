
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        [Required]
        [StringLength(30)]
        public string Status { get; set; } = "Booked";
        // Booked, Confirmed, CheckedIn,
        // Completed, Cancelled, NoShow

        [StringLength(500)]
        public string? Reason { get; set; }

        [StringLength(1000)]
        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; }
            = DateTime.UtcNow;

        // Navigation properties
        public Patient Patient { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;

        public ICollection<Encounter> Encounters
            { get; set; } = new List<Encounter>();
    }
}
