using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces.Services
{
    public interface IDoctorService
    {
        Task<Doctor?> GetDoctorAsync(int id);
        Task<IEnumerable<Doctor>> GetAllDoctorsAsync();
        Task AddDoctorAsync(Doctor doctor);
        Task UpdateDoctorAsync(Doctor doctor);
        Task DeleteDoctorAsync(int id);
    }
}
