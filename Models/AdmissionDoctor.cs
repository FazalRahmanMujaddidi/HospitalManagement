
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class AdmissionDoctor
    {
        public int AdmissionId { get; set; }
        public int DoctorId { get; set; }

        public DateTime AssignedAt { get; set; }
            = DateTime.UtcNow;

        [StringLength(100)]
        public string? Role { get; set; }

        // Navigation properties
        public Admission Admission { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
    }
}
