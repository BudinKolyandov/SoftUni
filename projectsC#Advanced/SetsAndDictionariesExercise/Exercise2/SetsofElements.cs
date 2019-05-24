using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise2
{
    class SetsofElements
    {
        static void Main(string[] args)
        {
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();            
            int[] lengths = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lengths[0]; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                firstSet.Add(currentNum);
            }
            for (int i = 0; i < lengths[1]; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                secondSet.Add(currentNum);
 
            }

            Console.WriteLine(string.Join(' ',firstSet.Intersect(secondSet)));


        }
    }
}
