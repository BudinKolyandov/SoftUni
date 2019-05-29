using System;
using System.Collections.Generic;

namespace Exercise10
{
    class Crossroads
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string input = string.Empty;
            char symbol = '\0';
            int totalCars = 0;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                    continue;
                }
                int currentGreen = greenLight;
                while (currentGreen > 0 && cars.Count > 0)
                {
                    string car = cars.Dequeue();
                    int carLength = car.Length;
                    if (currentGreen - carLength >= 0)
                    {
                        currentGreen -= carLength;
                        totalCars++;
                    }
                    else
                    {
                        currentGreen += freeWindow;
                        if (currentGreen - carLength >= 0)
                        {
                            totalCars++;
                            break;
                        }
                        else
                        {
                            symbol = car[currentGreen];
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{car} was hit at {symbol}.");
                            return;
                        }
                    }
                    
                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCars} total cars passed the crossroads.");
        }
    }
}
