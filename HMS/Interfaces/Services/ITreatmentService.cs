using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces.Services
{
    public interface ITreatmentService
    {
        Task<Treatment?> GetTreatmentAsync(int id);
        Task<IEnumerable<Treatment>> GetAllTreatmentsAsync();
        Task AddTreatmentAsync(Treatment treatment);
        Task UpdateTreatmentAsync(Treatment treatment);
        Task DeleteTreatmentAsync(int id);
    }
}
