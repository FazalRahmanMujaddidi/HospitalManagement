
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Nurse
    {
        [Key]
        public int NurseId { get; set; }

        // Optional ASP.NET Core Identity account
        public string? UserId { get; set; }

        [Required]
        [StringLength(30)]
        public string EmployeeNumber { get; set; }
            = string.Empty;

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
            = string.Empty;

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
            = string.Empty;

        [StringLength(30)]
        public string? Phone { get; set; }

        [EmailAddress]
        [StringLength(150)]
        public string? Email { get; set; }

        [StringLength(50)]
        public string? LicenseNumber { get; set; }

        [StringLength(100)]
        public string? Qualification { get; set; }

        public DateOnly? HireDate { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; }
            = DateTime.UtcNow;

        // Relationship
        public ICollection<MedicationAdministration>
            MedicationAdministrations { get; set; }
            = new List<MedicationAdministration>();
    }
}
