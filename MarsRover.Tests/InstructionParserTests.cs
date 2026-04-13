using MarsRoverApp.RawInputParser;
using MarsRoverApp.RoverMovement;
namespace MarsRover.Tests
{
    public class InstructionParserTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void ParseInputInstructions_ShouldReturnL_WhenStringInputIsL()
        {
            string input = "L";
            
            List<Instruction> output = InstructionParser.ParseInputInstructions(input);
            List<Instruction> result = new List<Instruction> { Instruction.L };

            Assert.That(result, Is.EqualTo(output));

        }
        [Test]
        public void ParseInputInstructions_ShouldReturnLLL_WhenStringInputIsLLL()
        {
            string input = "LLL";

            List<Instruction> output = InstructionParser.ParseInputInstructions(input);
            List<Instruction> result = new List<Instruction> { Instruction.L, Instruction.L, Instruction.L };
            

            Assert.That(result, Is.EqualTo(output));
        }
        [Test]
        public void ParseInputInstructions_ShouldReturnLLL_WhenStringInputIncludesSpaces()
        {
            string input = "L L L";

            List<Instruction> output = InstructionParser.ParseInputInstructions(input);
            List<Instruction> result = new List<Instruction> { Instruction.L, Instruction.L, Instruction.L };


            Assert.That(result, Is.EqualTo(output));
        }

        [Test]
        public void ParseInputInstructions_ShouldReturnLLL_WhenStringInputIsLowerCase()
        {
            string input = "l l l";

            List<Instruction> output = InstructionParser.ParseInputInstructions(input);
            List<Instruction> result = new List<Instruction> { Instruction.L, Instruction.L, Instruction.L };


            Assert.That(result, Is.EqualTo(output));
        }
        [Test]
        public void ParseInputInstructions_ShouldThrowException_WhenInvalidCharsAreInput()
        {
            string input = "123";

            Assert.Throws<ArgumentException>(() => { InstructionParser.ParseInputInstructions(input); });
        }
        [Test]
        public void ParseInputInstructions_ShouldReturnOutput_WhenGivenLargerStringInput()
        {
            string input = "LMRLLRRMML";
            List<Instruction> output = InstructionParser.ParseInputInstructions(input);
            List<Instruction> result = new List<Instruction> { Instruction.L, Instruction.M,
                                        Instruction.R, Instruction.L, Instruction.L, Instruction.R,
                                        Instruction.R, Instruction.M, Instruction.M, Instruction.L };

            Assert.That(result, Is.EqualTo(output));
        }
    }
}