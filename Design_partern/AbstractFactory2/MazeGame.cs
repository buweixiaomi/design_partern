using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_partern.AbstractFactory2
{
    public class MazeGame
    {
        public Maze CreateMaze(MazeFactory mazeFactory)
        {
            Maze aMaze = mazeFactory.MakeMaze();
            Room r1 = mazeFactory.MakeRoom(1);
            Room r2 = mazeFactory.MakeRoom(2);
            Door theDoor = mazeFactory.MakeDoor(r1, r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSite(Direction.East, mazeFactory.MakeWall());
            r1.SetSite(Direction.North, theDoor);
            r1.SetSite(Direction.South, mazeFactory.MakeWall());
            r1.SetSite(Direction.West, mazeFactory.MakeWall());

            r2.SetSite(Direction.East, mazeFactory.MakeWall());
            r2.SetSite(Direction.North, mazeFactory.MakeWall());
            r2.SetSite(Direction.South, mazeFactory.MakeWall());
            r2.SetSite(Direction.West, theDoor);

            return aMaze;
        }
    }
}
