﻿using System;
using System.Linq;

namespace Exercise8
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> compare = (n1, n2) =>
              (n1 % 2 == 0 && n2 % 2 != 0) ? -1 :
              (n1 % 2 != 0 && n2 % 2 == 0) ? 1 :
              n1.CompareTo(n2);

            Array.Sort<int>(numbers, new Comparison<int>(compare));

            Console.WriteLine(string.Join(' ', numbers));
           
        }
    }
}