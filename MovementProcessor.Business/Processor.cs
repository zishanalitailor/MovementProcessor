using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovementProcessor.Domain;
using MovementProcessor.Interfaces;

namespace MovementProcessor.Business
{
    public class Processor : IProcessor
    {
        private readonly Robot _robot;
        public Processor(Robot robot)
        {
            _robot = robot;
        }


        public Robot Move(string direction)
        {
            return Process(direction);
        }


        private Robot Process(string direction)
        {
            foreach (char dir in direction)
            {
                switch (dir)
                {
                    case '<':
                        {
                            GetDirection(dir, "anticlockwise");
                            break;
                        }
                    case '>':
                        {
                            GetDirection(dir, "clockwise");
                            break;
                        }
                    case '^':
                        {
                            switch (_robot.DirectionOfMovement)
                            {
                                case 'N':
                                    {
                                        _robot.y = _robot.y + 1;
                                        break;
                                    }
                                case 'S':
                                    {
                                        _robot.y = _robot.y - 1;
                                        break;
                                    }
                                case 'E':
                                    {
                                        _robot.x = _robot.x + 1;
                                        break;
                                    }
                                case 'W':
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

        private void GetDirection(char direction, string rotation)
        {
            if (rotation == "clockwise")
            {

                if (_robot.DirectionOfMovement == 'N')
                {
                    _robot.DirectionOfMovement = 'E';
                    return;
                }
                if (_robot.DirectionOfMovement == 'E')
                {
                    _robot.DirectionOfMovement = 'S';
                    return;
                }
                if (_robot.DirectionOfMovement == 'S')
                {
                    _robot.DirectionOfMovement = 'W';
                    return;
                }
                if (_robot.DirectionOfMovement == 'W')
                {
                    _robot.DirectionOfMovement = 'N';
                    return;
                }

            }
            else
            {
                if (_robot.DirectionOfMovement == 'N')
                {
                    _robot.DirectionOfMovement = 'W';
                    return;
                }
                if (_robot.DirectionOfMovement == 'W')
                {
                    _robot.DirectionOfMovement = 'S';
                    return;
                }
                if (_robot.DirectionOfMovement == 'S')
                {
                    _robot.DirectionOfMovement = 'E';
                    return;
                }
                if (_robot.DirectionOfMovement == 'E')
                {
                    _robot.DirectionOfMovement = 'N';
                    return;
                }
            }

        }
    }
}
