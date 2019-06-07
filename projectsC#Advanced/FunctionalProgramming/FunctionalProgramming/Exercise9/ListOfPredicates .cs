using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise9
{
    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            List<int> numbers = Enumerable.Range(1, range).ToList();

            List<int> dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < dividers.Count; i++)
            {
                Predicate<int> divisible = num =>
                { return num % dividers[i] == 0; };
                numbers = numbers.FindAll(divisible);
            }


            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
