using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovementProcessor.Domain;
using MovementProcessor.Business;
using MovementProcessor.Interfaces;

namespace MovementProcessor.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot()
            {
                x = 1,
                y = 2,
                DirectionOfMovement = 'N'
            };


            IProcessor processor = new Processor(robot);
            robot = processor.Move("<^<^<^<^^");
            System.Console.ReadKey();

        }
    }
}
