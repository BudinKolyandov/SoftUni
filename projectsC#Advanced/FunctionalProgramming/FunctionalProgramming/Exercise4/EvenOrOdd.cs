using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string type = Console.ReadLine();

            int firstNum = range[0];
            int lastNum = range[1];

            List<int> numbers = new List<int>();

            for (int i = firstNum; i <= lastNum; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> isEven = x => x % 2 == 0;
            Predicate<int> isOdd = x => x % 2 != 0;

            if (type == "odd")
            {
                Console.WriteLine(string.Join(' ', numbers.Where(x => isOdd(x))));                
            }
            else
            {
                Console.WriteLine(string.Join(' ', numbers.Where(x => isEven(x))));
            }


        }
    }
}
