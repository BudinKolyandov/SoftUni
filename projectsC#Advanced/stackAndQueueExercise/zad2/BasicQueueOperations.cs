using System;
using System.Collections.Generic;
using System.Linq;

namespace zad2
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            string[] stackRules = Console.ReadLine().Split().ToArray();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            int n = int.Parse(stackRules[0]);
            int s = int.Parse(stackRules[1]);
            int x = int.Parse(stackRules[2]);
            
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(input[i]);
            }
            if (queue.Count > s)
            {
                for (int i = 0; i < s; i++)
                {
                    queue.Dequeue();
                }
            }
            else
            {
                queue.Clear();
            }
            if (queue.Count > 0)
            {
                if (queue.Contains(x))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int minNumber = int.MaxValue;
                    while (queue.Count != 0)
                    {
                        int current = queue.Peek();
                        if (current < minNumber)
                        {
                            minNumber = current;
                        }
                        queue.Dequeue();
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
