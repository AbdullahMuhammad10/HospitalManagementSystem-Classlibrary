using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository repository;
        public StaffService(IStaffRepository repository) => this.repository = repository;

        public async Task<Staff?> GetStaffAsync(int id) => await repository.GetByIdAsync(id);
        public async Task<IEnumerable<Staff>> GetAllStaffAsync() => await repository.GetAllAsync();

        public async Task AddStaffAsync(Staff staff)
        {
            await repository.AddAsync(staff);
            await repository.SaveChangesAsync();
        }

        public async Task UpdateStaffAsync(Staff staff)
        {
            await repository.UpdateAsync(staff);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteStaffAsync(int id)
        {
            await repository.DeleteAsync(id);
            await repository.SaveChangesAsync();
        }
    }
}
