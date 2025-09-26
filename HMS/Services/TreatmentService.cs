using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class TreatmentService : ITreatmentService
    {
        private readonly ITreatmentRepository repository;
        public TreatmentService(ITreatmentRepository repository) => this.repository = repository;

        public async Task<Treatment?> GetTreatmentAsync(int id) => await repository.GetByIdAsync(id);
        public async Task<IEnumerable<Treatment>> GetAllTreatmentsAsync() => await repository.GetAllAsync();

        public async Task AddTreatmentAsync(Treatment treatment)
        {
            await repository.AddAsync(treatment);
            await repository.SaveChangesAsync();
        }

        public async Task UpdateTreatmentAsync(Treatment treatment)
        {
            await repository.UpdateAsync(treatment);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteTreatmentAsync(int id)
        {
            await repository.DeleteAsync(id);
            await repository.SaveChangesAsync();
        }
    }
}
