using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp.RawInputParser
{
    public class InstructionParser
    {
        
        public static List<Instruction> ParseInputInstructions(string instruction)
        {
            var validChars = new[] { 'L', 'R', 'M', ' '};
            if (!instruction.ToUpper().All(c => validChars.Contains(c)))
            {
                throw new ArgumentException("Invalid input, please provide correct Instruction");
            }
            var inputInstructionList = instruction
                                       .ToUpper()
                                       .Where(c => !char.IsWhiteSpace(c))
                                       .Select(c => Enum.Parse<Instruction>(c.ToString()))
                                       .ToList();

            foreach (var instructions in inputInstructionList)
            {
                Console.WriteLine(instructions);
            }
            return inputInstructionList;
        }
    }
}
