using System;
using System.Collections.Generic;
using System.Linq;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string [] input = Console.ReadLine().Split().ToArray();
            int sum = 0;
            int number = 0;
            foreach (var item in input)
            {
                stack.Push(item);
            }
            Stack<string> revStack = new Stack<string>();
            while (stack.Count != 0)
            {
                revStack.Push(stack.Pop());
            }
            sum = int.Parse(revStack.Peek());
            
            while (revStack.Count != 0)
            {
                string current = revStack.Peek();

                if (current == "+")
                {
                    revStack.Pop();
                    number = int.Parse(revStack.Peek());
                    sum += number;
                }
                if (current == "-")
                {
                    revStack.Pop();
                    number = int.Parse(revStack.Peek());
                    sum -= number;
                }
                revStack.Pop();
            }
            Console.WriteLine(sum);


        }
    }
}
