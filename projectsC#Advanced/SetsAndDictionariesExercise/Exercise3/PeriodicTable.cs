using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            SortedSet<string> uniqueElemnts = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (var element in elements)
                {
                    uniqueElemnts.Add(element);
                }
            }

            Console.WriteLine(string.Join(' ', uniqueElemnts));







        }
    }
}
