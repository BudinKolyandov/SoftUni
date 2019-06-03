using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class CustomMinFunction
    {
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> min = num =>
            {
                int minValue = int.MaxValue;
                foreach (var number in input)
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }
                return minValue;
            };
            Action<int> print = x => Console.WriteLine(x);
            int lowestInt = min(input);
            print(lowestInt);
        }

    }
}
