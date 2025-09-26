using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces.Services
{
    public interface IDepartmentService
    {
        Task<Department?> GetDepartmentAsync(int id);
        Task<IEnumerable<Department>> GetAllDepartmentsAsync();
        Task AddDepartmentAsync(Department department);
        Task UpdateDepartmentAsync(Department department);
        Task DeleteDepartmentAsync(int id);
    }
}
