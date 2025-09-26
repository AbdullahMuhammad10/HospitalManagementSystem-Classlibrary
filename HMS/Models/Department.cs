using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;

        public ICollection<Doctor>? Doctors { get; set; }
        public ICollection<Nurse>? Nurses { get; set; }
        public ICollection<Room>? Rooms { get; set; }
    }
}
