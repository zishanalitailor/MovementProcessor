using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovementProcessor.Domain;
using MovementProcessor.Domain.Helper;
using MovementProcessor.Interfaces;

namespace MovementProcessor.Business
{
    public class DirectionChanger : IDirectionChanger
    {
        public Direction GetDirection1(char instruction, Rotation rotation)
        {
            if (rotation == Rotation.Anticlockwise)
            {
                if (instruction == 'N')
                { 
                    return Direction.West;
                }
                if (instruction == 'W')
                {
                    return Direction.South;
                }
                if (instruction == 'S')
                {
                    return Direction.East;
                }
                if (instruction == 'E')
                {
                    return Direction.North;
                }
            }
            else
            {
                if (instruction == 'N')
                {
                    return Direction.East;
                }
                if (instruction == 'E')
                {
                    return Direction.South;
                }
                if (instruction == 'S')
                {
                    return Direction.West;
                }
                if (instruction == 'W')
                {
                    return Direction.North;
                }
            }
            throw new Exception();
        }
        public Direction GetDirection(Direction direction, Rotation rotation)
        {
            if (rotation == Rotation.Anticlockwise)
            {
                if (direction == Direction.North)
                {
                    direction = Direction.West;
                    return direction;
                }
                if (direction == Direction.West)
                {
                    direction = Direction.South;
                    return direction;
                }
                if (direction == Direction.South)
                {
                    direction = Direction.East;
                    return direction;
                }
                if (direction == Direction.East)
                {
                    direction = Direction.North;
                    return direction;
                } 
            }
            else
            {
                if (direction == Direction.North)
                {
                    direction = Direction.East;
                    return direction;
                }
                if (direction == Direction.East)
                {
                    direction = Direction.South;
                    return direction;
                }
                if (direction == Direction.South)
                {
                    direction = Direction.West;
                    return direction;
                }
                if (direction == Direction.West)
                {
                    direction = Direction.North;
                    return direction;
                }
            }
            throw new Exception();
        }
    }
}
