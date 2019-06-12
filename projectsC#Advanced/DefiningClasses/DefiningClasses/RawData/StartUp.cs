using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Car[] cars = new Car[n];

            for (int i = 0; i < n; i++)
            {                
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);

                cars[i] = new Car(model, new Engine(engineSpeed, enginePower),
                    new Cargo(cargoWeight, cargoType),
                    new List<Tire> {new Tire(tire1Pressure, tire1Age), new Tire(tire2Pressure, tire2Age),
                    new Tire(tire3Pressure, tire3Age), new Tire(tire4Pressure,tire4Age)});
                
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                Car[] sortedCars = cars.Where(x => x.Cargo.CargoType == "fragile")
                    .Where(x => x.Tires.Any(y => y.Presure < 1)).ToArray();
                foreach (var car in sortedCars)
                {
                    Console.WriteLine(car.Model);
                }                    
            }
            else if (command == "flamable")
            {
                Car[] sortedCars = cars.Where(x => x.Cargo.CargoType == "flamable")
                    .Where(x => x.Engine.EnginePower > 250).ToArray();
                foreach (var car in sortedCars)
                {
                    Console.WriteLine(car.Model);
                }

            }


        }
    }
}
