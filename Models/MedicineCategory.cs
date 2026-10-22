
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class MedicineCategory
    {
        [Key]
        public int MedicineCategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        // Relationship
        public ICollection<Medicine> Medicines { get; set; }
            = new List<Medicine>();
    }
}
