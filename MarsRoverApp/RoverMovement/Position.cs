using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp.RoverMovement
{
    public class Position(int x, int y, Compass facing)
    {
        public int X { get; set; } = x;
        public int Y { get; set; } = y;
        public Compass Facing { get; set; } = facing;

    }

}
