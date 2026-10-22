
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class DoctorSchedule
    {
        [Key]
        public int ScheduleId { get; set; }

        public int DoctorId { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        [Range(1, 240)]
        public int SlotDurationMinutes { get; set; } = 15;

        public DateOnly EffectiveFrom { get; set; }
        public DateOnly? EffectiveTo { get; set; }

        public bool IsAvailable { get; set; } = true;

        public Doctor Doctor { get; set; } = null!;
    }
}
