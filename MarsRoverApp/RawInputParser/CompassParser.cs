using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp.RawInputParser
{
    public class CompassParser
    {
        public static Compass ParseInputDirection(string direction)
        {
            var validChars = new[] { 'N', 'W', 'E', 'S' };
            
            if (string.IsNullOrEmpty(direction) || direction.Length != 1 || !validChars.Contains(char.ToUpper(direction[0])))
            {
                throw new ArgumentException("Invalid input, please provide correct Direction");
            }
                        
            return Enum.Parse<Compass>(direction.ToUpper());
        }
    }
}
