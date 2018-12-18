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
        public char GetDirection(char instruction, Rotation rotation)
        {
            if (rotation == Rotation.Anticlockwise)
            {
                if (instruction == 'N')
                {
                    instruction = 'W';
                    return instruction;
                }
                if (instruction == 'W')
                {
                    instruction = 'S';
                    return instruction;
                }
                if (instruction == 'S')
                {
                    instruction = 'E';
                    return instruction;
                }
                if (instruction == 'E')
                {
                    instruction = 'N';
                    return instruction;
                } 
            }
            else
            {
                if (instruction == 'N')
                {
                    instruction = 'E';
                    return instruction;
                }
                if (instruction == 'E')
                {
                    instruction = 'S';
                    return instruction;
                }
                if (instruction == 'S')
                {
                    instruction = 'W';
                    return instruction;
                }
                if (instruction == 'W')
                {
                    instruction = 'N';
                    return instruction;
                }
            }
            throw new Exception();
        }
    }
}
