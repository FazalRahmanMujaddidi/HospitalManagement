using HospitalManagement.Models;
namespace HospitalManagement.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public ICollection<SubDepartment> SubDepartments
        {
            get; set;
        } = new List<SubDepartment>();

        public ICollection<Doctor> Doctors
        {
            get; set;
        } = new List<Doctor>();

        public ICollection<Ward> Wards
        {
            get; set;
        } = new List<Ward>();
    }
}
