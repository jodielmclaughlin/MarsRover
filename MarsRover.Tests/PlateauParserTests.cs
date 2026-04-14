using MarsRoverApp.RawInputParser;
using MarsRoverApp.RoverMovement;

namespace MarsRover.Tests
{
    public class PlateauParserTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ParseInputPlateauSize_ShouldReturnNewPlateauSize_WhenGivenStringInput()
        {
            string input = "5";
            string input2 = "5";
            PlateauSize output = PlateauParser.ParseInputPlateauSize(input, input2);
            PlateauSize result = new PlateauSize(5,5);
            var resultCheck = output.X;
            var resultCheck2 = output.Y;

            Assert.That(resultCheck, Is.EqualTo(5));
            Assert.That(resultCheck2, Is.EqualTo(5));
        }
        [Test]
        public void ParseInputPlateauSize_ShouldReturnNull_WhenGivenEmptyStringInput()
        {
            string input = "";
            string input2 = "5";
            PlateauSize output = PlateauParser.ParseInputPlateauSize(input, input2); ;
            PlateauSize result = null;
            Assert.That(output, Is.EqualTo(result));
        }
        [Test]
        public void ParseInputPlateauSize_ShouldReturn0_WhenGivenNullInput()
        {
            string input = null;
            string input2 = "5";
            PlateauSize output = PlateauParser.ParseInputPlateauSize(input, input2); ;
            PlateauSize result = null;
            Assert.That(output, Is.EqualTo(result));
        }
        [Test]
        public void ParseInputPlateauSize_ShouldReturn0_WhenGivenCharStringInput()
        {
            string input = "c";
            string input2 = "5";
            PlateauSize output = PlateauParser.ParseInputPlateauSize(input, input2); ;
            PlateauSize result = null;
            Assert.That(output, Is.EqualTo(result));

        }
        [Test]
        public void ParseInputPlateauSize_ShouldReturn0_WhenGivenSentenceStringInput()
        {
            string input = "hello";
            string input2 = "world!";
            PlateauSize output = PlateauParser.ParseInputPlateauSize(input, input2); ;
            PlateauSize result = null;
            Assert.That(output, Is.EqualTo(result));
        }
        [Test]
        public void ParseInputPlateauSize_ShouldReturn0_WhenGivenMixedCharAndDigitStringInput()
        {
            string input = "h3ll0";
            string input2 = "w0rld!";
            PlateauSize output = PlateauParser.ParseInputPlateauSize(input, input2);
            PlateauSize result = null;
            Assert.That(output, Is.EqualTo(result));
        }
        [Test] 
        public void ParseInputPlateauSize_ShouldThrowException_WhenGivenStringInputLargerThan5()
        {
            string input = "77";
            string input2 = "5";
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { PlateauParser.ParseInputPlateauSize(input, input2); });
        }

        

    }
}