using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty; // Admin, Receptionist, etc.
        public string Phone { get; set; } = string.Empty;
    }
}
