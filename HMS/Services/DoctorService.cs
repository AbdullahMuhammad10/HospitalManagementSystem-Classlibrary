using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository repository;
        public DoctorService(IDoctorRepository repository) => this.repository = repository;

        public async Task<Doctor?> GetDoctorAsync(int id) => await repository.GetByIdAsync(id);
        public async Task<IEnumerable<Doctor>> GetAllDoctorsAsync() => await repository.GetAllAsync();

        public async Task AddDoctorAsync(Doctor doctor)
        {
            await repository.AddAsync(doctor);
            await repository.SaveChangesAsync();
        }

        public async Task UpdateDoctorAsync(Doctor doctor)
        {
            await repository.UpdateAsync(doctor);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteDoctorAsync(int id)
        {
            await repository.DeleteAsync(id);
            await repository.SaveChangesAsync();
        }
    }
}
