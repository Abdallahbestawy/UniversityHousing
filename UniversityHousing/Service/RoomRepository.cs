using UniversityHousing.Models;

namespace UniversityHousing.Service
{
    public class RoomRepository : IRoomRepository
    {
        public readonly HousingContext context;
        public RoomRepository(HousingContext _context)
        {
            context = _context;
        }
        public int Create(Room room)
        {
            context.Rooms.Add(room);
            int raw = context.SaveChanges();
            return raw;
        }

        public int Delete(int id)
        {
            var room = context.Rooms.FirstOrDefault(r=>r.RoomId == id);
            if (room != null)
            {
                context.Rooms.Remove(room);
                int raw = context.SaveChanges();
                return raw;
            }
            else
            {
                return 0;
            }
        }

        public List<Room> GetAll()
        {
            List<Room> rooms = context.Rooms.ToList();
            return rooms;
        }

        public Room? GetById(int id)
        {
            var room = context.Rooms.FirstOrDefault(r=>r.RoomId == id);
            if (room != null)
            {
                return room;
            }
            else
            {
                return null;
            }
        }

        public int Update(int id, Room room)
        {
            var oldRoom = context.Rooms.FirstOrDefault(r=> r.RoomId == id);
            if (oldRoom != null)
            {
                oldRoom.RoomName = room.RoomName;
                oldRoom.RoomPrice = room.RoomPrice;
                oldRoom.AvailableOfBed = room.AvailableOfBed;
                oldRoom.NumberOfBed = room.NumberOfBed;
            }
            return context.SaveChanges();
        }
    }
}
