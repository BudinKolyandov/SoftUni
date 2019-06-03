using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class ActionPoint
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            words.ForEach(delegate (String word)
            {
                Console.WriteLine(word);
            });

        }
    }
}
