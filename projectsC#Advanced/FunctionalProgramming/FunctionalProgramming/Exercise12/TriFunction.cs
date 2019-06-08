using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise12
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split().ToArray();

            Func<string, int, bool> isLarger = (name, charsLength)
                => name.Sum(x => x) >= charsLength;

            Func<string[], Func<string, int, bool>, string> nameFilter = (inputNames, filter)
                => inputNames.FirstOrDefault(x => filter(x, sum));

            string result = nameFilter(names, isLarger);
            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(String.Empty);
            }

        }
    }
}
