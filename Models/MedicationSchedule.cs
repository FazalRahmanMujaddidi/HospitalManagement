
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class MedicationSchedule
    {
        public int MedicationScheduleId { get; set; }

        public int MedicationOrderId { get; set; }

        public DateTime ScheduledAt { get; set; }

        [MaxLength(30)]
        public string Status { get; set; } = "Pending";
        // Pending, Administered, Missed, Cancelled

        [MaxLength(500)]
        public string? Notes { get; set; }

        // Navigation properties
        public MedicationOrder MedicationOrder { get; set; } = null!;

        public ICollection<MedicationAdministration> Administrations
            { get; set; } = new List<MedicationAdministration>();
    }
}
