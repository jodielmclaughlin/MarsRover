using MarsRoverApp.RawInputParser;
using MarsRoverApp.RoverMovementLogic;
using MarsRoverApp.RoverMovement;
namespace MarsRover.Tests.LogicTests;

public class RoverTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Rotate_ShouldReturnCompassE_WhenInputIsInstructionRAndPositionIsCompassN()
    {
        Rover firstRover = new Rover(new Position(1, 4, Compass.N), "Handsome Boy");

        var input = Instruction.R;
        var output = firstRover.Rotate(firstRover, input);
        var result = Compass.E;

        Assert.That(result, Is.EqualTo(output));
    }
    [Test]
    public void Rotate_ShouldReturnCompassS_WhenInputIsInstructionRAndPositionIsCompassE()
    {
        Rover firstRover = new Rover(new Position(1, 4, Compass.E), "Handsome Boy");

        var input = Instruction.R;
        var output = firstRover.Rotate(firstRover, input);
        var result = Compass.S;

        Assert.That(result, Is.EqualTo(output));
    }
    [Test]
    public void Rotate_ShouldReturnCompassW_WhenInputIsInstructionRAndPositionIsCompassS()
    {
        Rover firstRover = new Rover(new Position(1, 4, Compass.S), "Handsome Boy");

        var input = Instruction.R;
        var output = firstRover.Rotate(firstRover, input);
        var result = Compass.W;

        Assert.That(result, Is.EqualTo(output));
    }
    [Test]
    public void Rotate_ShouldReturnCompassW_WhenInputIsInstructionLAndPositionIsCompassN()
    {
        Rover firstRover = new Rover(new Position(1, 4, Compass.N), "Handsome Boy");

        var input = Instruction.L;
        var output = firstRover.Rotate(firstRover, input);
        var result = Compass.W;

        Assert.That(result, Is.EqualTo(output));
    }
    [Test]
    public void Rotate_ShouldReturnCompassS_WhenInputIsInstructionLAndPositionIsCompassW()
    {
        Rover firstRover = new Rover(new Position(1, 4, Compass.W), "Handsome Boy");

        var input = Instruction.L;
        var output = firstRover.Rotate(firstRover, input);
        var result = Compass.S;

        Assert.That(result, Is.EqualTo(output));
    }
    [Test]
    public void Rotate_ShouldReturnCompassE_WhenInputIsInstructionLAndPositionIsCompassS()
    {
        Rover firstRover = new Rover(new Position(1, 4, Compass.S), "Handsome Boy");

        var input = Instruction.L;
        var output = firstRover.Rotate(firstRover, input);
        var result = Compass.E;

        Assert.That(result, Is.EqualTo(output));
    }
    [Test]
    public void Rotate_ShouldReturnCompassN_WhenInputIsInstructionLAndPositionIsCompassE()
    {
        Rover firstRover = new Rover(new Position(1, 4, Compass.E), "Handsome Boy");

        var input = Instruction.L;
        var output = firstRover.Rotate(firstRover, input);
        var result = Compass.N;

        Assert.That(result, Is.EqualTo(output));
    }
    [Test]
    public void Rotate_ShouldReturnCompassN_WhenInputIsInstructionRAndPositionIsCompassW()
    {
        Rover firstRover = new Rover(new Position(1, 4, Compass.W), "Handsome Boy");

        var input = Instruction.R;
        var output = firstRover.Rotate(firstRover, input);
        var result = Compass.N;

        Assert.That(result, Is.EqualTo(output));
    }
    [Test]
    public void Rotate_ShouldThrowException_WhenInputIsInstructionM()
    {
        Rover firstRover = new Rover(new Position(1, 4, Compass.W), "Handsome Boy");

        var input = Instruction.M;
        
        Assert.Throws<ArgumentException>(() => { firstRover.Rotate(firstRover, input); });
     }
    [Test]
    public void Rotate_ShouldThrowException_WhenRoverInputIsNull()
    {
        Rover firstRover = null;

        var input = Instruction.M;

        Assert.Throws<NullReferenceException>(() => { firstRover.Rotate(firstRover, input); });
    }
    [Test]
    public void MoveForward_ShouldReturnNewPosition_WhenInstructionMIsInput()
    {
        Rover firstRover = new Rover(new Position(1, 4, Compass.N), "Handsome Boy");

        var input = Instruction.M;
        var output = firstRover.MoveForward(firstRover, input);
        var result = new Position(2, 4, Compass.N);
        var resultCheck = output.X;
        var resultCheck2 = output.Y;
        var resultCheck3 = output.Facing;

        Assert.That(resultCheck, Is.EqualTo(2));
        Assert.That(resultCheck2, Is.EqualTo(4));
        Assert.That(resultCheck3, Is.EqualTo(Compass.N));
    }
    [Test]
    public void MoveForward_ShouldReturnPosition15E_WhenInstructionMIsInput()
    {
        Rover firstRover = new Rover(new Position(1, 4, Compass.E), "Handsome Boy");

        var input = Instruction.M;
        var output = firstRover.MoveForward(firstRover, input);
        var result = new Position(1, 5, Compass.E);
        var resultCheck = output.X;
        var resultCheck2 = output.Y;
        var resultCheck3 = output.Facing;

        Assert.That(resultCheck, Is.EqualTo(1));
        Assert.That(resultCheck2, Is.EqualTo(5));
        Assert.That(resultCheck3, Is.EqualTo(Compass.E));
    }
    [Test]
    public void MoveForward_ShouldReturnPosition13W_WhenInstructionMIsInput()
    {
        Rover firstRover = new Rover(new Position(1, 4, Compass.W), "Handsome Boy");

        var input = Instruction.M;
        var output = firstRover.MoveForward(firstRover, input);
        var result = new Position(1, 3, Compass.W);
        var resultCheck = output.X;
        var resultCheck2 = output.Y;
        var resultCheck3 = output.Facing;

        Assert.That(resultCheck, Is.EqualTo(1));
        Assert.That(resultCheck2, Is.EqualTo(3));
        Assert.That(resultCheck3, Is.EqualTo(Compass.W));
    }
    [Test]
    public void MoveForward_ShouldReturnPosition33S_WhenInstructionMIsInput()
    {
        Rover firstRover = new Rover(new Position(4, 3, Compass.S), "Handsome Boy");

        var input = Instruction.M;
        var output = firstRover.MoveForward(firstRover, input);
        var result = new Position(3, 3, Compass.S);
        var resultCheck = output.X;
        var resultCheck2 = output.Y;
        var resultCheck3 = output.Facing;

        Assert.That(resultCheck, Is.EqualTo(3));
        Assert.That(resultCheck2, Is.EqualTo(3));
        Assert.That(resultCheck3, Is.EqualTo(Compass.S));
    }
    [Test]
    public void MoveForward_ShouldThrowException_WhenRoverInputIsNull()
    {
        Rover firstRover = null;
        var input = Instruction.M;
        Assert.Throws<NullReferenceException>(() => { firstRover.MoveForward(firstRover, input); });
    }
}
