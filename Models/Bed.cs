
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HospitalManagement.Models;
namespace HospitalManagement.Models
{
    public class Bed
    {
        public int BedId { get; set; }

        public int WardId { get; set; }

        [Required]
        [MaxLength(20)]
        public string BedNumber { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? BedType { get; set; }
        // Standard, ICU, Pediatric, Private

        [Required]
        [MaxLength(30)]
        public string Status { get; set; } = "Available";
        // Available, Occupied, Reserved, Maintenance

        public bool IsActive { get; set; } = true;

        // Navigation properties
        public Ward Ward { get; set; } = null!;

        public ICollection<Admission> Admissions { get; set; }
            = new List<Admission>();
    }
}
