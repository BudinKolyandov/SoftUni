using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise6
{
    class AutoRepairAndService
    {
        static void Main(string[] args)
        {
            string [] input = Console.ReadLine().Split(' ').ToArray();
            List<string> servedVechicles = new List<string>();
            Queue<string> queue = new Queue<string>(input);
            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "End")
            {
                string[] command = commands.Split('-').ToArray();
                string currentCommand = command[0];
                if (currentCommand == "Service" && queue.Count > 0)
                {
                    servedVechicles.Add(queue.Peek());
                    Console.WriteLine($"Vehicle {queue.Dequeue()} got served.");
                }
                if (currentCommand == "CarInfo")
                {
                    string car = command[1];
                    if (queue.Contains(car))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    if (servedVechicles.Contains(car))
                    {
                        Console.WriteLine("Served.");
                    }
                }
                if (currentCommand == "History")
                {
                    servedVechicles.Reverse();
                    Console.WriteLine(string.Join(", ", servedVechicles));
                    servedVechicles.Reverse();
                }
                
            }
            if (queue.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", queue)}");
            }
            servedVechicles.Reverse();
            Console.WriteLine($"Served vehicles: {string.Join(", ", servedVechicles)}");
        }
    }
}
