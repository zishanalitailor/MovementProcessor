using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovementProcessor.Domain.Helper
{
    public static class DirectionHelper
    {
        public static Direction GetDirection(char direction)
        {
            switch (direction)
            {
                case 'N':
                    return Direction.North;
                case 'S':
                    return Direction.South;
                case 'E':
                    return Direction.East;
                case 'W':
                    return Direction.West;
            }
            throw new Exception();
        }
    }
}
