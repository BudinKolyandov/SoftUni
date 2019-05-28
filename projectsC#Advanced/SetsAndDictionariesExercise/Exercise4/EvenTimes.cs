using System;
using System.Collections.Generic;

namespace Exercise4
{
    class EvenTimes
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(currentNum))
                {
                    dict.Add(currentNum, 1);
                }
                else
                {
                    dict[currentNum] += 1;
                }
            }

            foreach (var item in dict)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }


        }
    }
}
