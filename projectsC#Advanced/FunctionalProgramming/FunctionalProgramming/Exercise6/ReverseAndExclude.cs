using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise6
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int delimeter = int.Parse(Console.ReadLine());

            Func<int, bool> divisible = x => x % delimeter != 0;

            numbers = numbers.Where(divisible).Reverse().ToList();

            Console.WriteLine(string.Join(' ', numbers));

        }
    }
}
