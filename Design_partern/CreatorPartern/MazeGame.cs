using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_partern.CreatorPartern
{
    public class MazeGame
    {
        public Maze CreateMaze()
        {
            Maze aMaze = new Maze();
            Room r1 = new Room(1);
            Room r2 = new Room(2);
            Door theDoor = new Door(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSite(Direction.East, new Wall());
            r1.SetSite(Direction.North, theDoor);
            r1.SetSite(Direction.South, new Wall());
            r1.SetSite(Direction.West, new Wall());

            r2.SetSite(Direction.East, new Wall());
            r2.SetSite(Direction.North, new Wall());
            r2.SetSite(Direction.South, new Wall());
            r2.SetSite(Direction.West, theDoor);

            return aMaze;
        }
    }
}
