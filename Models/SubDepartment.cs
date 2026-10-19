namespace HospitalManagement.Models{
    public class SubDepartment
{
    public int SubDepartmentId { get; set; }

    public int DepartmentId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;

    public Department Department { get; set; } = null!;

    public ICollection<Doctor> Doctors
        { get; set; } = new List<Doctor>();
}
}