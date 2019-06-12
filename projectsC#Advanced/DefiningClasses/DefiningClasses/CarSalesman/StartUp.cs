using System;
using System.Collections.Generic;

namespace CarSalesman
{
    class CarSalesman 
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                if (engineInfo.Length == 2)
                {
                    engines.Add(new Engine(engineModel, power));
                }
                if (engineInfo.Length == 3)
                {
                    int displacement;
                    bool isInt = int.TryParse(engineInfo[2], out displacement);
                    if (isInt)
                    {
                        engines.Add(new Engine(engineModel, power, displacement));
                    }
                    else
                    {
                        string efficiency = engineInfo[2];
                        engines.Add(new Engine(engineModel, power, efficiency));
                    }
                }
                if (engineInfo.Length == 4)
                {
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];
                    engines.Add(new Engine(engineModel, power, displacement, efficiency));
                }
                           
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                string engineModel = carInfo[1];
                Engine engine = new Engine(null, 0);

                foreach (Engine eng in engines)
                {
                    if (eng.Model == engineModel)
                    {
                        engine = eng;
                    }
                }

                if (carInfo.Length == 2)
                {
                    cars.Add(new Car(model, engine));
                }
                if (carInfo.Length == 3)
                {
                    int weight;
                    bool isInt = int.TryParse(carInfo[2], out weight);
                    if (isInt)
                    {
                        cars.Add(new Car(model, engine, weight));
                    }
                    else
                    {
                        string color = carInfo[2];
                        cars.Add(new Car(model, engine, color));
                    }
                }
                if (carInfo.Length == 4)
                {
                    int weight = int.Parse(carInfo[2]);
                    string color = carInfo[3];
                    cars.Add(new Car(model, engine, weight, color));
                }

            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.engine.Model}:");
                Console.WriteLine($"    Power: {car.engine.Power}");
                if (car.engine.Displacement == 0)
                {
                    Console.WriteLine(@"    Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"    Displacement: {car.engine.Displacement}");
                }
                Console.WriteLine($"    Efficiency: {car.engine.Efficiency}");
                if (car.Weight == 0)
                {
                    Console.WriteLine(@"  Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                Console.WriteLine($"  Color: {car.Color}");
            }

        }
    }
}
