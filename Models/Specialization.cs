
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Specialization
    {
        [Key]
        public int SpecializationId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        // Relationship: one specialization can have many doctors
        public ICollection<Doctor> Doctors { get; set; }
            = new List<Doctor>();
    }
}

