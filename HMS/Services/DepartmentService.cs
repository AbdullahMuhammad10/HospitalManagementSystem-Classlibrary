using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository repository;
        public DepartmentService(IDepartmentRepository repository) => this.repository = repository;

        public async Task<Department?> GetDepartmentAsync(int id) => await repository.GetByIdAsync(id);
        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync() => await repository.GetAllAsync();

        public async Task AddDepartmentAsync(Department department)
        {
            await repository.AddAsync(department);
            await repository.SaveChangesAsync();
        }

        public async Task UpdateDepartmentAsync(Department department)
        {
            await repository.UpdateAsync(department);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteDepartmentAsync(int id)
        {
            await repository.DeleteAsync(id);
            await repository.SaveChangesAsync();
        }
    }
}
