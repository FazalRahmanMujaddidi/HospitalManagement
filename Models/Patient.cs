
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        [StringLength(30)]
        public string MedicalRecordNumber { get; set; }
            = string.Empty;

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
            = string.Empty;

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
            = string.Empty;

        public DateOnly? DateOfBirth { get; set; }

        [StringLength(20)]
        public string? Gender { get; set; }

        [StringLength(30)]
        public string? Phone { get; set; }

        [StringLength(300)]
        public string? Address { get; set; }

        [StringLength(150)]
        public string? EmergencyContactName { get; set; }

        [StringLength(30)]
        public string? EmergencyContactPhone { get; set; }

        public DateTime CreatedAt { get; set; }
            = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        // Relationships

        public ICollection<Appointment> Appointments
            { get; set; } = new List<Appointment>();

        public ICollection<Encounter> Encounters
            { get; set; } = new List<Encounter>();

        public ICollection<Admission> Admissions
            { get; set; } = new List<Admission>();

        public ICollection<FollowUp> FollowUps
            { get; set; } = new List<FollowUp>();
    }
}
