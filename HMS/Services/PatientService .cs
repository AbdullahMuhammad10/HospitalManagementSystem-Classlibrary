using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository repository;

        public PatientService(IPatientRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Patient?> GetPatientAsync(int id) => await repository.GetByIdAsync(id);

        public async Task<IEnumerable<Patient>> GetAllPatientsAsync() => await repository.GetAllAsync();

        public async Task AddPatientAsync(Patient patient)
        {
            await repository.AddAsync(patient);
            await repository.SaveChangesAsync();
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            await repository.UpdateAsync(patient);
            await repository.SaveChangesAsync();
        }

        public async Task DeletePatientAsync(int id)
        {
            await repository.DeleteAsync(id);
            await repository.SaveChangesAsync();
        }
    }
}
