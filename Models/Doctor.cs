
using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        // Foreign keys
        public int DepartmentId { get; set; }
        public int? SubDepartmentId { get; set; }
        public int SpecializationId { get; set; }

        // Optional account link (ASP.NET Core Identity)
        public string? UserId { get; set; }

        [Required]
        [StringLength(30)]
        public string EmployeeNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [StringLength(30)]
        public string? Phone { get; set; }

        [EmailAddress]
        [StringLength(150)]
        public string? Email { get; set; }

        [StringLength(50)]
        public string? LicenseNumber { get; set; }

        public bool IsActive { get; set; } = true;

        // Navigation properties
        public Department Department { get; set; } = null!;
        public SubDepartment? SubDepartment { get; set; }
        public Specialization Specialization { get; set; } = null!;

        public ICollection<DoctorSchedule> DoctorSchedules
            { get; set; } = new List<DoctorSchedule>();

        public ICollection<Appointment> Appointments
            { get; set; } = new List<Appointment>();

        public ICollection<Encounter> Encounters
            { get; set; } = new List<Encounter>();

        public ICollection<Diagnosis> Diagnoses
            { get; set; } = new List<Diagnosis>();

        public ICollection<AdmissionDoctor> AdmissionDoctors
            { get; set; } = new List<AdmissionDoctor>();

        public ICollection<MedicationOrder> MedicationOrders
            { get; set; } = new List<MedicationOrder>();

        public ICollection<Prescription> Prescriptions
            { get; set; } = new List<Prescription>();
    }
}
