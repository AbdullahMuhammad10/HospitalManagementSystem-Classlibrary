using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class BillService : IBillService
    {
        private readonly IBillRepository repository;
        public BillService(IBillRepository repository) => this.repository = repository;

        public async Task<Bill?> GetBillAsync(int id) => await repository.GetByIdAsync(id);
        public async Task<IEnumerable<Bill>> GetAllBillsAsync() => await repository.GetAllAsync();

        public async Task AddBillAsync(Bill bill)
        {
            await repository.AddAsync(bill);
            await repository.SaveChangesAsync();
        }

        public async Task UpdateBillAsync(Bill bill)
        {
            await repository.UpdateAsync(bill);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteBillAsync(int id)
        {
            await repository.DeleteAsync(id);
            await repository.SaveChangesAsync();
        }
    }
}
