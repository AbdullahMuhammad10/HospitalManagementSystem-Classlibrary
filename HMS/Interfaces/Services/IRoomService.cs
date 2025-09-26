using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces.Services
{
    public interface IRoomService
    {
        Task<Room?> GetRoomAsync(int id);
        Task<IEnumerable<Room>> GetAllRoomsAsync();
        Task AddRoomAsync(Room room);
        Task UpdateRoomAsync(Room room);
        Task DeleteRoomAsync(int id);
    }
}
