using System;
using System.Collections.Generic;

namespace SetsAndDictionariesExercise1
{
    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                if (!names.ContainsValue(name))
                {
                    names.Add(i, name);
                }

            }
            foreach (var kvp in names)
            {
                Console.WriteLine(kvp.Value);
            }

        }
    }
}
