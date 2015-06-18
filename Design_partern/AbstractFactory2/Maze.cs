using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_partern.AbstractFactory2
{
    public class Maze
    {
        Dictionary<int, Room> _rooms;
        public Maze()
        {
            _rooms = new Dictionary<int, Room>();
        }
        public void AddRoom(Room room)
        {
            _rooms.Add(room.RoomNo, room);
        }
        public Room RoomNo(int roomNo)
        {
            return _rooms[roomNo];
        }
    }
}
