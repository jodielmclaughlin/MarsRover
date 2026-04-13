using MarsRoverApp.RawInputParser;

namespace MarsRoverApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PlateauParser.ParseInputPlateauSize("5", "5");
            InstructionParser.ParseInputInstructions("L L L");
            
        }
    }
}
