﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            if (args != null && args.Any())
            {
                // This is to ensure that argument count is always odd number 3,5,7 etc
                if ((args.Count() + 1) % 2 != 0)
                {
                    System.Console.WriteLine("The arguments passed are not correct. Please retry");
                    return;
                }

                //Here we can get the rquest and assing it to robot
                var container = new UnityContainer();
                container.RegisterType<ProgramStarter, ProgramStarter>();

                ResiterTypes(container);

                var program = container.Resolve<ProgramStarter>();
                Robot robot = null;
                for (int i = 0; i < args.Count(); i++)
                {
                    string argument = args[i].ToString();
                    // Now this will be space separated string
                    // We need to get the data from it
                    string[] argss = argument.Split(' ');

                    if (i == 0)
                    {
                        continue;
                        // we still haven't got anything to map "5 5" to anything
                        // it should be written here
                    }
                    if ((i + 1) % 2 == 0)// The robot object must be the argument in even order
                    {
                        robot = new Robot();
                        robot.x = argss[0] != null ? Convert.ToInt32(argss[0]) : 0;
                        robot.y = argss[1] != null ? Convert.ToInt32(argss[1]) : 0;
                        robot.DirectionOfMovement = DirectionHelper.GetDirection(argss[2] != null ? Convert.ToChar(argss[2]) : 'N');
                    }
                    try
                    {
                        if ((i + 2) % 3 == 0)// This will make sure that third argument is mapped as instruction
                        {
                            program.Run(robot, args[i].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Console.WriteLine("Something went wrong : " + ex.InnerException);
                    }
                }
            }
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

        public void Run(Robot robot, string instuction)
        {
            iProcessor.robot = robot;
            robot = iProcessor.Move(instuction);
            System.Console.WriteLine("{0} {1} {2}", robot.x.ToString(), robot.y.ToString(), robot.DirectionOfMovement.ToString());
        }
    }
}
