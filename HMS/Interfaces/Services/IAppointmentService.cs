using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces.Services
{
    public interface IAppointmentService
    {
        Task<Appointment?> GetAppointmentAsync(int id);
        Task<IEnumerable<Appointment>> GetAllAppointmentsAsync();
        Task ScheduleAppointmentAsync(Appointment appointment);
        Task UpdateAppointmentAsync(Appointment appointment);
        Task CancelAppointmentAsync(int id);
    }
}
