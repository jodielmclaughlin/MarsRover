using MarsRoverApp.RoverMovement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp.RoverMovementLogic
{
    public class Plateau
    {
        public PlateauSize Size { get; set; }
        public Plateau(PlateauSize size) 
        {
            Size = size;
        }

        public bool IsWithinPlateauSize(PlateauSize size, Position position)
        {
            
            if (position.X > size.X || position.X < 0 || position.Y > size.Y || position.Y < 0)
            {
                return false;
            }
            return true;
        }
    }
}
