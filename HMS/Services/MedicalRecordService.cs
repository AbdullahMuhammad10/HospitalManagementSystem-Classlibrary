using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class MedicalRecordService : IMedicalRecordService
    {
        private readonly IMedicalRecordRepository repository;
        public MedicalRecordService(IMedicalRecordRepository repository) => this.repository = repository;

        public async Task<MedicalRecord?> GetRecordAsync(int id) => await repository.GetByIdAsync(id);
        public async Task<IEnumerable<MedicalRecord>> GetAllRecordsAsync() => await repository.GetAllAsync();

        public async Task AddRecordAsync(MedicalRecord record)
        {
            await repository.AddAsync(record);
            await repository.SaveChangesAsync();
        }

        public async Task UpdateRecordAsync(MedicalRecord record)
        {
            await repository.UpdateAsync(record);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteRecordAsync(int id)
        {
            await repository.DeleteAsync(id);
            await repository.SaveChangesAsync();
        }
    }
}
