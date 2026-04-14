using MarsRoverApp.RawInputParser;
using MarsRoverApp.RoverMovement;

namespace MarsRover.Tests;

public class PositionParserTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ParsePositionInput_ShouldReturnOutput_WhenGivenStringInput()
    {
        string input = "14N";

        Position output = PositionParser.ParsePositionInput(input);
        Position result = new Position(1, 4, Compass.N);
        var resultCheck = output.X;
        var resultCheck2 = output.Y;
        var resultCheck3 = output.Facing;

        Assert.That(resultCheck, Is.EqualTo(1));
        Assert.That(resultCheck2, Is.EqualTo(4));
        Assert.That(resultCheck3, Is.EqualTo(Compass.N));
    }

    [Test]
    public void ParsePositionInput_ShouldReturn_WhenGivenStringInputWithSpaces()
    {
        string input = "1 4 N";

        Position output = PositionParser.ParsePositionInput(input);
        Position result = new Position(1, 4, Compass.N);
        var resultCheck = output.X;
        var resultCheck2 = output.Y;
        var resultCheck3 = output.Facing;

        Assert.That(resultCheck, Is.EqualTo(1));
        Assert.That(resultCheck2, Is.EqualTo(4));
        Assert.That(resultCheck3, Is.EqualTo(Compass.N));
    }

    [Test]
    public void ParsePositionInput_ShouldThrowException_WhenGivenTwoCompassDirs()
    {
        string input = "1NN";

        Assert.Throws<ArgumentException>(() => { PositionParser.ParsePositionInput(input); });
    }

    [Test]
    public void ParsePositionInput_ShouldThrowException_WhenGivenTooFewInstructions()
    {
        string input = "1N";

        Assert.Throws<ArgumentException>(() => { PositionParser.ParsePositionInput(input); });
    }
    [Test]
    public void ParsePositionInput_ShouldThrowException_WhenGivenStringWithTooMayInstructions()
    {
        string input = "14NN";

        Assert.Throws<ArgumentException>(() => { PositionParser.ParsePositionInput(input); });
    }
    [Test]
    public void ParsePositionInput_ShouldThrowException_WhenGivenEmptyString()
    {
        string input = "";

        Assert.Throws<ArgumentException>(() => { PositionParser.ParsePositionInput(input); });
    }
    [Test]
    public void ParsePositionInput_ShouldThrowException_WhenGivenNull()
    {
        string input = null;

        Assert.Throws<ArgumentException>(() => { PositionParser.ParsePositionInput(input); });
    }
    [Test]
    public void ParsePositionInput_ShouldReturnOutPut_WhenGivenLowerCaseDirection()
    {
        string input = "14n";
        Position output = PositionParser.ParsePositionInput(input);
        Position result = new Position(1, 4, Compass.N);
        var resultCheck = output.X;
        var resultCheck2 = output.Y;
        var resultCheck3 = output.Facing;

        Assert.That(resultCheck, Is.EqualTo(1));
        Assert.That(resultCheck2, Is.EqualTo(4));
        Assert.That(resultCheck3, Is.EqualTo(Compass.N));
    }
    [Test]
    public void ParsePositionInput_ShouldReturnOutPut_WhenGivenStringWithOneSpace()
    {
        string input = "14 N";
        Position output = PositionParser.ParsePositionInput(input);
        Position result = new Position(1, 4, Compass.N);
        var resultCheck = output.X;
        var resultCheck2 = output.Y;
        var resultCheck3 = output.Facing;

        Assert.That(resultCheck, Is.EqualTo(1));
        Assert.That(resultCheck2, Is.EqualTo(4));
        Assert.That(resultCheck3, Is.EqualTo(Compass.N));
    }
}
