
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class MedicationOrder
    {
        public int MedicationOrderId { get; set; }

        public int AdmissionId { get; set; }
        public int DoctorId { get; set; }
        public int MedicineId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Dose { get; set; } = string.Empty;

        [MaxLength(30)]
        public string? DoseUnit { get; set; }

        [MaxLength(50)]
        public string? Route { get; set; }

        [Required]
        [MaxLength(100)]
        public string Frequency { get; set; } = string.Empty;

        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }

        [MaxLength(500)]
        public string? Instructions { get; set; }

        [MaxLength(30)]
        public string Status { get; set; } = "Active";
        // Active, Completed, Discontinued, Cancelled

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public Admission Admission { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
        public Medicine Medicine { get; set; } = null!;

        public ICollection<MedicationSchedule> Schedules { get; set; }
            = new List<MedicationSchedule>();
    }
}
