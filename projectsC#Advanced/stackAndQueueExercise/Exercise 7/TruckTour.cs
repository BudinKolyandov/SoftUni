using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_7
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int firstPump = 0;
            int fuelLeft = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<int> currentPump = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                int petrol = currentPump[0];
                int distance = currentPump[1];

                fuelLeft += petrol;

                if (fuelLeft >= distance)
                {
                    fuelLeft -= distance;
                }
                else
                {
                    firstPump = i + 1;
                    fuelLeft = 0;
                }
            }

            Console.WriteLine(firstPump);

        }
    }
}
