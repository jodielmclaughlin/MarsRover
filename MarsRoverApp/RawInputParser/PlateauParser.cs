using MarsRoverApp.RoverMovement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp.RawInputParser
{
    public class PlateauParser
    {
        public static PlateauSize ParseInputPlateauSize(string size1, string size2)
        {
            if (String.IsNullOrEmpty(size1) || String.IsNullOrEmpty(size2))
            {
                
                return null;
            }
            if (!size1.All(char.IsDigit) || !size1.All(char.IsDigit))
            {
                return null;
            }

            int x = Int32.Parse(size1);
            int y = Int32.Parse(size2);
            if (x <= 5 && y <= 5)
            {
                PlateauSize parsedPlateausize = new PlateauSize(x, y);

                return parsedPlateausize;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid input, please provide number 5 or less");
            }
        }
    }
}
