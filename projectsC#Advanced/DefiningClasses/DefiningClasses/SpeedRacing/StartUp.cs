using SpeedRacing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carsList = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = cars[0];
                double fuel = double.Parse(cars[1]);
                double consumption = double.Parse(cars[2]);

                Car car = new Car(model, fuel, consumption);
                carsList.Add(car);
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = data[1];
                double distance = double.Parse(data[2]);

                Car car = carsList.FirstOrDefault(x => x.Model == model);
                car.Drive(distance);
            }

            foreach (Car car in carsList)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.Distance}");
            }

        }
    }
}
