
using System.ComponentModel.DataAnnotations;
using HospitalManagement.Models;
namespace HospitalManagement.Models
{
    public class Admission
    {
        [Key]
        public int AdmissionId { get; set; }

        // Required foreign keys
        public int PatientId { get; set; }
        public int DepartmentId { get; set; }
        public int WardId { get; set; }

        // Optional foreign keys
        public int? SubDepartmentId { get; set; }
        public int? BedId { get; set; }

        public DateTime AdmissionDate { get; set; }
            = DateTime.UtcNow;

        public DateTime? DischargeDate { get; set; }

        [StringLength(1000)]
        public string? Reason { get; set; }

        [Required]
        [StringLength(30)]
        public string Status { get; set; } = "Admitted";
        // Admitted, Discharged, Cancelled

        public DateTime CreatedAt { get; set; }
            = DateTime.UtcNow;

        // Relationships
        public Patient Patient { get; set; } = null!;
        public Department Department { get; set; } = null!;
        public SubDepartment? SubDepartment { get; set; }
        public Ward Ward { get; set; } = null!;
        public Bed? Bed { get; set; }

        public ICollection<AdmissionDoctor> AdmissionDoctors
            { get; set; } = new List<AdmissionDoctor>();

        public ICollection<Diagnosis> Diagnoses
            { get; set; } = new List<Diagnosis>();

        public ICollection<MedicationOrder> MedicationOrders
            { get; set; } = new List<MedicationOrder>();
    }
}
