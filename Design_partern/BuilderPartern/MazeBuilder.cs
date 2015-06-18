using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_partern.BuilderPartern
{
    public class MazeBuilder
    {
        public virtual void BuildMaze() { }

        public virtual void BuildDoor(int r1, int r2) { }

        public virtual void BuildWall() { }
        public virtual void BuildRoom(int roomNo) { }

        public virtual Maze GetMaze() { return null; }
    }
}
