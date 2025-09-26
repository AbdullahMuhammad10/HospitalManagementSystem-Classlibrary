using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces.Services
{
    public interface IStaffService
    {
        Task<Staff?> GetStaffAsync(int id);
        Task<IEnumerable<Staff>> GetAllStaffAsync();
        Task AddStaffAsync(Staff staff);
        Task UpdateStaffAsync(Staff staff);
        Task DeleteStaffAsync(int id);
    }
}
