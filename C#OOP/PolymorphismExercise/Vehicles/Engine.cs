using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            string[] carInfo = Console.ReadLine().Split();
            Car car = new Car(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            string[] truckInfo = Console.ReadLine().Split();
            Truck truck = new Truck(truckInfo[0], double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string currentCommand = commands[0];
                string type = commands[1];
                double commandDouble = double.Parse(commands[2]);

                if (type == "Car")
                {
                    if (currentCommand == "Drive")
                    {
                        car.Drive(commandDouble);
                    }
                    if (currentCommand == "Refuel")
                    {
                        car.Refuel(commandDouble);
                    }
                }
                if (type == "Truck")
                {
                    if (currentCommand == "Drive")
                    {
                        truck.Drive(commandDouble);
                    }
                    if (currentCommand == "Refuel")
                    {
                        truck.Refuel(commandDouble);
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());

        }
    }
}
