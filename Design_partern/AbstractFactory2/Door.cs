using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_partern.AbstractFactory2
{
    public class Door:MapSite
    {
        Room _room1;
        Room _room2;
        bool _isOpen;
        public Door(Room room1, Room room2) {
            _room1 = room1;
            _room2 = room2;
        }
        public Room OtherSideFrom(Room room)
        {
            if (room == _room1)
                return _room2;
            return _room1;
        }
    }
}
