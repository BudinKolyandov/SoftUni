using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise8
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            bool isValid = true;
            char[] valid = { '(', '[', '{' };
                       
            foreach(var i in input)
            {
                if (valid.Contains(i))
                {
                    stack.Push(i);
                    continue;
                }
                if (stack.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stack.Peek() == '(' && i == ')')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '{' && i == '}')
                {
                    stack.Pop();
                }
                else if (stack.Peek() == '[' && i == ']')
                {
                    stack.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }

            }
            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }



        }
    }
}
