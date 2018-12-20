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
