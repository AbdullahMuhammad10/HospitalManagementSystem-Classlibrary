using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public DateTime BillDate { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }

        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
    }
}
