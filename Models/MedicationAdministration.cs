
using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class MedicationAdministration
    {
        public int MedicationAdministrationId { get; set; }

        public int MedicationScheduleId { get; set; }
        public int NurseId { get; set; }

        public DateTime RecordedAt { get; set; } = DateTime.UtcNow;

        public DateTime? AdministeredAt { get; set; }

        [Required]
        [MaxLength(30)]
        public string Outcome { get; set; } = "Given";
        // Given, Refused, Withheld, NotGiven

        [MaxLength(500)]
        public string? Notes { get; set; }

        // Navigation properties
        public MedicationSchedule MedicationSchedule { get; set; } = null!;
        public Nurse Nurse { get; set; } = null!;
    }
}
