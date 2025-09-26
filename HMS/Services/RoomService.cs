using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository repository;
        public RoomService(IRoomRepository repository) => this.repository = repository;

        public async Task<Room?> GetRoomAsync(int id) => await repository.GetByIdAsync(id);
        public async Task<IEnumerable<Room>> GetAllRoomsAsync() => await repository.GetAllAsync();

        public async Task AddRoomAsync(Room room)
        {
            await repository.AddAsync(room);
            await repository.SaveChangesAsync();
        }

        public async Task UpdateRoomAsync(Room room)
        {
            await repository.UpdateAsync(room);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteRoomAsync(int id)
        {
            await repository.DeleteAsync(id);
            await repository.SaveChangesAsync();
        }
    }
}
