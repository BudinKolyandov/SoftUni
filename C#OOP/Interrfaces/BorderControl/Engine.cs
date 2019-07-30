using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl
{
    class Engine
    {
        List<Citizen> citizens;
        static List<string> banned = new List<string>();
        List<Robot> robots;
        public Engine()
        {
            citizens = new List<Citizen>();
            robots = new List<Robot>();
        }

        public void Run()
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] currentCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (currentCommand.Length == 3)
                {
                    Citizen citizen = new Citizen(currentCommand[0],
                       int.Parse(currentCommand[1]), currentCommand[2]);
                    citizens.Add(citizen);
                }
                if (currentCommand.Length == 2)
                {
                    Robot robot = new Robot(currentCommand[0],
                        currentCommand[1]);
                    robots.Add(robot);

                }
            }
            string digits = Console.ReadLine();

            foreach (var citizen in citizens)
            {
                citizen.Checker(citizen.Id, digits);
            }
            foreach (var robot in robots)
            {
                robot.Checker(robot.Id, digits);
            }
            Console.WriteLine(string.Join(Environment.NewLine, banned));
        }


        internal static void Add(string id)
        {
            banned.Add(id);
        }
    }
}
