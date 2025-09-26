using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository repository;
        public AppointmentService(IAppointmentRepository repository) => this.repository = repository;

        public async Task<Appointment?> GetAppointmentAsync(int id) => await repository.GetByIdAsync(id);
        public async Task<IEnumerable<Appointment>> GetAllAppointmentsAsync() => await repository.GetAllAsync();

        public async Task ScheduleAppointmentAsync(Appointment appointment)
        {
            await repository.AddAsync(appointment);
            await repository.SaveChangesAsync();
        }

        public async Task UpdateAppointmentAsync(Appointment appointment)
        {
            await repository.UpdateAsync(appointment);
            await repository.SaveChangesAsync();
        }

        public async Task CancelAppointmentAsync(int id)
        {
            await repository.DeleteAsync(id);
            await repository.SaveChangesAsync();
        }
    }
}
