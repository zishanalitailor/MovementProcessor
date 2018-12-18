using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovementProcessor.Domain;
using MovementProcessor.Domain.Helper;
using MovementProcessor.Business;
using MovementProcessor.Interfaces;
using Unity;

namespace MovementProcessor.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<ProgramStarter, ProgramStarter>();

            ResiterTypes(container);

            var program = container.Resolve<ProgramStarter>();

            System.Console.WriteLine("All done.Starting program...");

            Robot robot = new Robot()
            {
                x = 1,
                y = 2,
                DirectionOfMovement = (Direction)'N'
            };

            program.Run(robot);  
        }

        public static void ResiterTypes(IUnityContainer container)
        {
            container.RegisterType<IProcessor, Processor>();
            container.RegisterType<IDirectionChanger, DirectionChanger>();
        }
    }

    public class ProgramStarter
    {
        private readonly IProcessor iProcessor;

        public ProgramStarter(IProcessor iProcessor)
        { 
            this.iProcessor = iProcessor;
        }

        public void Run(Robot robot)
        {
            // IProcessor processor = new Processor(robot);
            iProcessor.robot = robot;
            robot = iProcessor.Move("<^<^<^<^^");
            System.Console.ReadKey();
        }
    }
}
