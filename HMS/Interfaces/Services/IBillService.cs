using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces.Services
{
    public interface IBillService
    {
        Task<Bill?> GetBillAsync(int id);
        Task<IEnumerable<Bill>> GetAllBillsAsync();
        Task AddBillAsync(Bill bill);
        Task UpdateBillAsync(Bill bill);
        Task DeleteBillAsync(int id);
    }
}
