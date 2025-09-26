using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces.Services
{
    public interface IMedicalRecordService
    {
        Task<MedicalRecord?> GetRecordAsync(int id);
        Task<IEnumerable<MedicalRecord>> GetAllRecordsAsync();
        Task AddRecordAsync(MedicalRecord record);
        Task UpdateRecordAsync(MedicalRecord record);
        Task DeleteRecordAsync(int id);
    }
}
