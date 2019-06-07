using System;
using System.Linq;

namespace Exercise7
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split();

            Func<string, bool> filter = name => name.Length <= length;

            Console.WriteLine(string.Join(Environment.NewLine, names.Where(filter)));
                                   
        }
    }
}
