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
        string input = "n";

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
}
