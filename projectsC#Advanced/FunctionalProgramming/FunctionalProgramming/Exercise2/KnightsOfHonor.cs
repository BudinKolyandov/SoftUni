using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise2
{
    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();

            words.ForEach(delegate (String word)
            {
                word = word.Insert(0, "Sir ");
                Console.WriteLine(word);
            });


        }
    }
}
