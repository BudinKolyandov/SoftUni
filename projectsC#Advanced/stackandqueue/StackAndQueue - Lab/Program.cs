using System;
using System.Collections.Generic;

namespace StackAndQueue___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            foreach (var ch in input)
            {
                stack.Push(ch.ToString());
            }
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
