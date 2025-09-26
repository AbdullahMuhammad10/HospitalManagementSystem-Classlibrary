using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces.Services
{
    public interface IPatientService
    {
        Task<Patient?> GetPatientAsync(int id);
        Task<IEnumerable<Patient>> GetAllPatientsAsync();
        Task AddPatientAsync(Patient patient);
        Task UpdatePatientAsync(Patient patient);
        Task DeletePatientAsync(int id);
    }
}
