using MarsRoverApp.RoverMovement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverApp.RoverMovementLogic
{
    public class Rover
    {
        public Position Position { get; set; }
        public string Name { get; set; }

        public Rover(Position position, string name)
        {
            Position = position;
            Name = name;
        }

        public Compass Rotate(Rover rover, Instruction instruction) //TODO: Refactor when time
        {
            if (rover == null)
            {
                throw new NullReferenceException("Rover needs to be input");
            }
            if (instruction == Instruction.M)
            { 
                throw new ArgumentException("Instruction M (Move) is not valid for rotation"); 
            }

            if (instruction == Instruction.R)
            {
                if (rover.Position.Facing == Compass.N)
                {
                    return Compass.E;
                }
                if (rover.Position.Facing == Compass.E)
                {
                    return Compass.S;
                }
                if (rover.Position.Facing == Compass.S)
                {
                    return Compass.W;
                }
            }
            else if(instruction == Instruction.L)
            {
                if (rover.Position.Facing == Compass.N)
                {
                    return Compass.W;
                }
                if (rover.Position.Facing == Compass.W)
                {
                    return Compass.S;
                }
                if (rover.Position.Facing == Compass.S)
                {
                    return Compass.E;
                }
            }
            return Compass.N;
        }

        public Position MoveForward(Rover rover, Instruction instruction) //Need to add Plateau Boundary Method to this.
        {
            if (rover == null)
            {
                throw new NullReferenceException("Rover needs to be input");
            }
            switch (rover.Position.Facing)
            {
                case Compass.N:
                    rover.Position.X++;
                    break;
                case Compass.E:
                    rover.Position.Y++;
                    break;
                case Compass.S:
                    rover.Position.X--;
                    break;
                case Compass.W:
                    rover.Position.Y--;
                    break;
            }

            return rover.Position;
        }
    }
}
