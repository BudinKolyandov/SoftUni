using System;
using System.Collections.Generic;
using System.Linq;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] stackRules = Console.ReadLine().Split().ToArray();
            int [] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(stackRules[0]);
            int s = int.Parse(stackRules[1]);
            int x = int.Parse(stackRules[2]);

            for (int i = 0; i < n; i++)
            {
                stack.Push(input[i]);
            }
            if (stack.Count > s)
            {
                for (int i = 0; i < s; i++)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Clear();
            }
            if (stack.Count>0)
            {
                if (stack.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int minNumber = int.MaxValue;
                    while (stack.Count != 0)
                    {
                        int current = stack.Peek();
                        if (current < minNumber)
                        {
                            minNumber = current;
                        }
                        stack.Pop();
                    }
                    Console.WriteLine(minNumber);
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
