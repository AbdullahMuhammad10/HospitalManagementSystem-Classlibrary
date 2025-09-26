using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Treatment
    {
        public int Id { get; set; }
        public string TreatmentName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }

        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        public int? NurseId { get; set; }
        public Nurse? Nurse { get; set; }
    }
}
