using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            string intInput = Console.ReadLine();
            int[] array = intInput.Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            foreach (var item in array)
            {
                stack.Push(item);
            }
            string input = string.Empty;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] instructions = input.Split().ToArray();
                string instruction = instructions[0];
                if (instruction == "add")
                {
                    int first = int.Parse(instructions[1]);
                    int second = int.Parse(instructions[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                else
                {
                    int count = int.Parse(instructions[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");

        }
    }
}
