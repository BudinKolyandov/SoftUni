using System;
using System.Collections.Generic;
using System.Linq;

namespace Excersice3
{
    class MaxAndMinElement
    {
        static void Main(string[] args)
        {
            int quieries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < quieries; i++)
            {
                int[] conditions = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int conditionType = conditions[0];
                switch (conditionType)
                {
                    case 1:
                        int numberToAdd = conditions[1];
                        stack.Push(numberToAdd);
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                            break;
                        }
                        break;                                               
                    case 3:
                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        
                        break;
                    case 4:
                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", stack));
            
        }
    }
}
