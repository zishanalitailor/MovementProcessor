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
    public class Processor : IProcessor// Interface
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

        private readonly IDirectionChanger _directionChanger;

        public Processor(IDirectionChanger directionChanger)
        {
            _directionChanger = directionChanger;
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
                            _robot.DirectionOfMovement =
                              _directionChanger.GetDirection(_robot.DirectionOfMovement, Rotation.Anticlockwise);
                            break;
                        }
                    case '>':
                        {
                            _robot.DirectionOfMovement =
                              _directionChanger.GetDirection(_robot.DirectionOfMovement, Rotation.Clockwise);
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
    }
}
