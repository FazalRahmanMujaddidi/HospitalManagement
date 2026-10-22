
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }

        public int SupplierId { get; set; }

        [Required]
        [MaxLength(50)]
        public string PurchaseNumber { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? SupplierInvoiceNumber { get; set; }

        public DateTime PurchaseDate { get; set; } = DateTime.UtcNow;

        public DateTime? ReceivedAt { get; set; }

        [MaxLength(30)]
        public string Status { get; set; } = "Draft";
        // Draft, Ordered, PartiallyReceived, Received, Cancelled

        [MaxLength(500)]
        public string? Notes { get; set; }

        // Navigation properties
        public Supplier Supplier { get; set; } = null!;

        public ICollection<PurchaseItem> Items { get; set; }
            = new List<PurchaseItem>();
    }
}
