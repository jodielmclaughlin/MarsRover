using MarsRoverApp.RawInputParser;
using MarsRoverApp.RoverMovement;

namespace MarsRover.Tests;

public class CompassParserTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ParseInputDirection_ShouldReturnN_WhenStringInputIsN()
    {
        string input = "N";

        var output = CompassParser.ParseInputDirection(input);
        var result =  Compass.N ;

        Assert.That(result, Is.EqualTo(output));

    }
    [Test]
    public void ParseInputInstructions_ShouldReturnException_WhenStringInputLengthIsLargerThan1Char()
    {
        string input = "NNN";


        Assert.Throws<ArgumentException>(() => { CompassParser.ParseInputDirection(input); });
    }
    [Test]
    public void ParseInputInstructions_ShouldReturnException_WhenStringInputIsNullOrEmpty()
    {
        string input = "";

        Assert.Throws<ArgumentException>(() => { CompassParser.ParseInputDirection(input); });
    }

    [Test]
    public void ParseInputInstructions_ShouldReturnN_WhenStringInputIsLowerCase()
    {
        string input = "N";

        var output = CompassParser.ParseInputDirection(input);
        var result = Compass.N;

        Assert.That(result, Is.EqualTo(output));
    }
    [Test]
    public void ParseInputInstructions_ShouldThrowException_WhenInvalidCharsAreInput()
    {
        string input = "1";

        Assert.Throws<ArgumentException>(() => { CompassParser.ParseInputDirection(input); });
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
