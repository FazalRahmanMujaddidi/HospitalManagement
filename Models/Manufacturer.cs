
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Manufacturer
    {
        [Key]
        public int ManufacturerId { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Country { get; set; }

        [StringLength(30)]
        public string? Phone { get; set; }

        [EmailAddress]
        [StringLength(150)]
        public string? Email { get; set; }

        [StringLength(300)]
        public string? Address { get; set; }

        public bool IsActive { get; set; } = true;

        // Relationship
        public ICollection<Medicine> Medicines { get; set; }
            = new List<Medicine>();
    }
}
