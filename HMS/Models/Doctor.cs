using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Specialty { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<Appointment>? Appointments { get; set; }
        public ICollection<Treatment>? Treatments { get; set; }
    }
}
