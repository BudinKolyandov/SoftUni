using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Exercise5
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int currentSum = 0;
            Stack<int> stack = new Stack<int>(input);
            int length = stack.Count;
            for (int i = 0; i < length; i++)
            {
                int value = stack.Peek();
                
                if (currentSum + value <= capacity)
                {
                    currentSum += stack.Pop();
                }
                else
                {
                    currentSum = stack.Pop();
                    racks++;
                }
            }
            Console.WriteLine(racks);



        }
    }
}
