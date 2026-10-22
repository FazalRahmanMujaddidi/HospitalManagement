
using System.Collections.Generic;

namespace HospitalManagement.Models
{
    public class Ward
    {
        public int WardId { get; set; }

        public int DepartmentId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? WardType { get; set; }

        public int? Floor { get; set; }

        public bool IsActive { get; set; } = true;

        public Department Department { get; set; } = null!;

        public ICollection<Bed> Beds { get; set; }
            = new List<Bed>();

        public ICollection<Admission> Admissions { get; set; }
            = new List<Admission>();
    }
}
