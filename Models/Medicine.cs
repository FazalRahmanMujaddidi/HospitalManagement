
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Medicine
    {
        [Key]
        public int MedicineId { get; set; }

        public int MedicineCategoryId { get; set; }
        public int ManufacturerId { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        [StringLength(150)]
        public string? GenericName { get; set; }

        [StringLength(150)]
        public string? BrandName { get; set; }

        [StringLength(50)]
        public string? DosageForm { get; set; }
        // Tablet, Capsule, Syrup, Injection, etc.

        [StringLength(50)]
        public string? Strength { get; set; }
        // Example: 500 mg

        [StringLength(50)]
        public string? Barcode { get; set; }

        [Range(0, int.MaxValue)]
        public int ReorderLevel { get; set; } = 10;

        public bool RequiresPrescription { get; set; } = true;

        [StringLength(1000)]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; }
            = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        // Navigation properties
        public MedicineCategory MedicineCategory
            { get; set; } = null!;

        public Manufacturer Manufacturer
            { get; set; } = null!;

        public ICollection<MedicineBatch> Batches
            { get; set; } = new List<MedicineBatch>();

        public ICollection<PrescriptionItem> PrescriptionItems
            { get; set; } = new List<PrescriptionItem>();

        public ICollection<MedicationOrder> MedicationOrders
            { get; set; } = new List<MedicationOrder>();
    }
}
