
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Models
{
    public class StockTransaction
    {
        public int StockTransactionId { get; set; }

        public int MedicineBatchId { get; set; }

        [Required]
        [MaxLength(30)]
        public string TransactionType { get; set; } = string.Empty;
        // PurchaseReceipt, Dispense, Return, Adjustment,
        // Expired, Damaged

        // Positive for stock added; negative for stock removed.
        [Precision(18, 2)]
        public decimal QuantityChange { get; set; }

        [Precision(18, 2)]
        public decimal? UnitCost { get; set; }

        [MaxLength(100)]
        public string? ReferenceNumber { get; set; }

        [MaxLength(500)]
        public string? Notes { get; set; }

        [MaxLength(450)]
        public string? PerformedByUserId { get; set; }

        public DateTime PerformedAt { get; set; } = DateTime.UtcNow;

        // Navigation property
        public MedicineBatch MedicineBatch { get; set; } = null!;
    }
}
