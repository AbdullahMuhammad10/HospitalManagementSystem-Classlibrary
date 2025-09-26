using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public string Type { get; set; } = "General"; // ICU, Surgery, etc.
        public bool IsAvailable { get; set; } = true;

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
