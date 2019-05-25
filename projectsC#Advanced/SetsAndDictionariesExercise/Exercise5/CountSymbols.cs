using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var ch in text)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict[ch] = 1;
                }
                else
                {
                    dict[ch] += 1;
                }
            }
            foreach (var kvp in dict.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }



        }
    }
}
