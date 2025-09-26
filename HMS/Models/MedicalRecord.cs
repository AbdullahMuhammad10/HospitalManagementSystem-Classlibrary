using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class MedicalRecord
    {
        public int Id { get; set; }
        public string Diagnosis { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime RecordDate { get; set; }

        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}
