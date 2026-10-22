
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? ContactPerson { get; set; }

        [MaxLength(30)]
        public string? Phone { get; set; }

        [EmailAddress]
        [MaxLength(150)]
        public string? Email { get; set; }

        [MaxLength(250)]
        public string? Address { get; set; }

        [MaxLength(100)]
        public string? TaxNumber { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<Purchase> Purchases { get; set; }
            = new List<Purchase>();
    }
}
