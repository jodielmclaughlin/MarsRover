using MarsRoverApp.RoverMovement;
using MarsRoverApp.RoverMovementLogic;

namespace MarsRover.Tests.LogicTests;

public class PlateauTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void IsWithinPlateauSize_ShouldReturnTrue()
    {
        PlateauSize size = new PlateauSize(5, 5);
        Plateau plateau = new Plateau(size);
        var input = new Position(3, 5, Compass.N);
        var output = plateau.IsWithinPlateauSize(size, input);
        
        Assert.That(output, Is.True);
    }
    [Test]
    public void IsWithinPlateauSize_ShouldReturnFalse()
    {
        PlateauSize size = new PlateauSize(5, 5);
        Plateau plateau = new Plateau(size);
        var input = new Position(6, 5, Compass.N);
        var output = plateau.IsWithinPlateauSize(size, input);
        
        Assert.That(output, Is.False);
    }
    [Test]
    public void IsWithinPlateauSize_ShouldReturnFalse_WhenGivenNegativePosition()
    {
        PlateauSize size = new PlateauSize(5, 5);
        Plateau plateau = new Plateau(size);
        var input = new Position(-1, 5, Compass.N);
        var output = plateau.IsWithinPlateauSize(size, input);

        Assert.That(output, Is.False);
    }
    [Test]
    public void IsWithinPlateauSize_ShouldReturnTrue_WhenGivenPosition0()
    {
        PlateauSize size = new PlateauSize(5, 5);
        Plateau plateau = new Plateau(size);
        var input = new Position(0, 0, Compass.N);
        var output = plateau.IsWithinPlateauSize(size, input);

        Assert.That(output, Is.True);
    }
    [Test]
    public void IsWithinPlateauSize_ShouldThrowError_WhenPlateauSizeIsNull()
    {
        PlateauSize size = null;
        Plateau plateau = new Plateau(size);
        var input = new Position(1, 4, Compass.N);
        Assert.Throws<NullReferenceException>(() => { plateau.IsWithinPlateauSize(size, input); });
    }
}
