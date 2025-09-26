using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class NurseService : INurseService
    {
        private readonly INurseRepository repository;
        public NurseService(INurseRepository repository) => this.repository = repository;

        public async Task<Nurse?> GetNurseAsync(int id) => await repository.GetByIdAsync(id);
        public async Task<IEnumerable<Nurse>> GetAllNursesAsync() => await repository.GetAllAsync();

        public async Task AddNurseAsync(Nurse nurse)
        {
            await repository.AddAsync(nurse);
            await repository.SaveChangesAsync();
        }

        public async Task UpdateNurseAsync(Nurse nurse)
        {
            await repository.UpdateAsync(nurse);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteNurseAsync(int id)
        {
            await repository.DeleteAsync(id);
            await repository.SaveChangesAsync();
        }
    }
}
