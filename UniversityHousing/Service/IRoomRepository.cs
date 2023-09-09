using UniversityHousing.Models;

namespace UniversityHousing.Service
{
    public interface IRoomRepository
    {
        int Create(Room room);
        int Update(int id,Room room);
        int Delete(int id);
        List<Room> GetAll();
        Room? GetById(int id);
    }
}
