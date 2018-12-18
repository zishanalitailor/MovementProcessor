using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovementProcessor.Domain.Helper;
using MovementProcessor.Domain;
using MovementProcessor.Interfaces;

namespace MovementProcessor.Business
{
    public class Processor : IProcessor
    {
        private Robot _robot;
        public Robot robot
        {
            get
            {
                return _robot;
            }
            set
            {
                _robot = value;
            }
        }

        public Robot Move(string instructions)
        {
            return Process(instructions);
        } 
        private Robot Process(string instructions)
        {
            foreach (char instruction in instructions)
            {
                switch (instruction)
                {
                    case '<':
                        {
                            GetDirection(instruction, Rotation.Anticlockwise);
                            break;
                        }
                    case '>':
                        {
                            GetDirection(instruction, Rotation.Clockwise);
                            break;
                        }
                    case '^':
                        {
                            switch (_robot.DirectionOfMovement)
                            {
                                case Direction.North:
                                    {
                                        _robot.y = _robot.y + 1;
                                        break;
                                    }
                                case Direction.South:
                                    {
                                        _robot.y = _robot.y - 1;
                                        break;
                                    }
                                case Direction.East:
                                    {
                                        _robot.x = _robot.x + 1;
                                        break;
                                    }
                                case Direction.West:
                                    {
                                        _robot.x = _robot.x - 1;
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }
            return _robot;
        }

        private void GetDirection(char direction, Rotation rotation)
        {
            if (rotation == Rotation.Anticlockwise)
            {

                if (_robot.DirectionOfMovement == Direction.North)
                {
                    _robot.DirectionOfMovement = Direction.East;
                    return;
                }
                if (_robot.DirectionOfMovement == Direction.East)
                {
                    _robot.DirectionOfMovement = Direction.South;
                    return;
                }
                if (_robot.DirectionOfMovement == Direction.South)
                {
                    _robot.DirectionOfMovement = Direction.West;
                    return;
                }
                if (_robot.DirectionOfMovement == Direction.West)
                {
                    _robot.DirectionOfMovement = Direction.North;
                    return;
                }

            }
            else
            {
                if (_robot.DirectionOfMovement == Direction.North)
                {
                    _robot.DirectionOfMovement = Direction.West;
                    return;
                }
                if (_robot.DirectionOfMovement == Direction.West)
                {
                    _robot.DirectionOfMovement = Direction.South;
                    return;
                }
                if (_robot.DirectionOfMovement == Direction.South)
                {
                    _robot.DirectionOfMovement = Direction.East;
                    return;
                }
                if (_robot.DirectionOfMovement == Direction.East)
                {
                    _robot.DirectionOfMovement = Direction.North;
                    return;
                }
            }

        }
    }
}
