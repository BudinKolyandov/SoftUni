using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Car car = CreateCar(parameters);

                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(x => x.CargoType == "fragile" && x.tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = cars
                    .Where(x => x.CargoType == "flamable" && x.EnginePower > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }

        private static Car CreateCar(string[] parameters)
        {
            string model = parameters[0];
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            Engine engine = new Engine(engineSpeed, enginePower);
            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            double firstTirePressure = double.Parse(parameters[5]);
            int firstTireAge = int.Parse(parameters[6]);
            Tire firstTire = new Tire(firstTireAge, firstTirePressure);
            double secondTirePressure = double.Parse(parameters[7]);
            int secondTireage = int.Parse(parameters[8]);
            Tire secondTire = new Tire(secondTireage, secondTirePressure);
            double thirdTirePressure = double.Parse(parameters[9]);
            int thirdTireage = int.Parse(parameters[10]);
            Tire thirdTire = new Tire(thirdTireage, thirdTirePressure);
            double fourthTirePressure = double.Parse(parameters[11]);
            int fourthTireage = int.Parse(parameters[12]);
            Tire fourthTire = new Tire(fourthTireage, fourthTirePressure);
            Tire[] tires = new Tire[] { firstTire, secondTire, thirdTire, fourthTire };
            var car = new Car(model,
                             engine,
                             cargo,
                             firstTire,
                             secondTire,
                             thirdTire,
                             fourthTire
                             );
            return car;
        }
    }
}
