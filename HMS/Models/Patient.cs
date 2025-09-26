using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public ICollection<Appointment>? Appointments { get; set; }
        public ICollection<MedicalRecord>? MedicalRecords { get; set; }
        public ICollection<Bill>? Bills { get; set; }
        public ICollection<Treatment>? Treatments { get; set; }
    }
}
