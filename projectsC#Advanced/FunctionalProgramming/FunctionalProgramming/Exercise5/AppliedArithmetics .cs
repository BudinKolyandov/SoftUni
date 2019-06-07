using System;
using System.Linq;

namespace Exercise5
{
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int> add = x => x += 1;
            Func<int, int> subtract = x => x -= 1;
            Func<int, int> multiply = x => x *= 2;
            Action<int[]> print = num =>
            Console.WriteLine(string.Join(' ', num));

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    numbers = numbers.Select(add).ToArray();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiply).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(subtract).ToArray();
                }
                else if (command == "print")
                {
                    print(numbers);
                }
            }




        }
    }
}
