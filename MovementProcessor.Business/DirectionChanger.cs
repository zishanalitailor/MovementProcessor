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
                }
                if (direction == Direction.West)
                {
                    direction = Direction.South;
                }
                if (direction == Direction.South)
                {
                    direction = Direction.East;
                }
                if (direction == Direction.East)
                {
                    direction = Direction.North;
                }
            }
            else
            {
                if (direction == Direction.North)
                {
                    direction = Direction.East;
                }
                if (direction == Direction.East)
                {
                    direction = Direction.South;
                }
                if (direction == Direction.South)
                {
                    direction = Direction.West;
                }
                if (direction == Direction.West)
                {
                    direction = Direction.North;
                }
            }
            return direction;
        }
    }
}
