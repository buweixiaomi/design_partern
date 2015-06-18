using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_partern.AbstractFactory2
{
    public class Room : MapSite
    {
        int _roonNumber;
        Dictionary<Direction, MapSite> _sides = new Dictionary<Direction, MapSite>();

        public Room(int roonNo)
        { }
        public MapSite GetSite(Direction direction) { return _sides[direction]; }
        public void SetSite(Direction direction, MapSite site) { _sides.Add(direction, site); }
        public override void Enter()
        {
            base.Enter();
        }

        public int RoomNo
        {
            get { return _roonNumber; }
        }

    }
}
