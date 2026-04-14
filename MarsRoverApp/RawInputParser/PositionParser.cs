using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverApp.RoverMovement;

namespace MarsRoverApp.RawInputParser
{
    public class PositionParser
    {
        public static Position ParsePositionInput(string position)
        {
            if (string.IsNullOrWhiteSpace(position))
            {
                throw new ArgumentException("Invalid input, please provide correct Position");
            }

            var validChars = new[] { 'N', 'W', 'E', 'S' };

            var noWhiteSpace = new string(position.ToUpper().Where(c=> !char.IsWhiteSpace(c)).ToArray());

            if(noWhiteSpace.Length != 3)
            {
                throw new ArgumentException("Invalid input, please provide correct Position");
            }
            
            char xChar = noWhiteSpace[0];
            char yChar = noWhiteSpace[1];
            char dirChar = noWhiteSpace[2];

            if(!char.IsDigit(xChar) ||  !char.IsDigit(yChar) || !validChars.Contains(dirChar))
            {
                throw new ArgumentException("Invalid input, please provide correct Position");
            }
            //TODO: split up the string, int x = position[0], int y = position[1], Compass facing = position[2]
            
            int x = Int32.Parse(xChar.ToString());
            int y = Int32.Parse(yChar.ToString());
            Compass facing = Enum.Parse<Compass>(dirChar.ToString());

            return new Position(x, y, facing);
        }
    }
}
