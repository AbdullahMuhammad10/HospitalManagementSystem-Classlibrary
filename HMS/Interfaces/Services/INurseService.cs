using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces.Services
{
    public interface INurseService
    {
        Task<Nurse?> GetNurseAsync(int id);
        Task<IEnumerable<Nurse>> GetAllNursesAsync();
        Task AddNurseAsync(Nurse nurse);
        Task UpdateNurseAsync(Nurse nurse);
        Task DeleteNurseAsync(int id);
    }
}
