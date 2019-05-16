using System;
using System.Collections.Generic;
using System.Linq;

namespace Excersice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityAvailable = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);

            int sum = 0;

            int bigestSell = queue.Max();

            for (int i = 0; i < orders.Length; i++)
            {
                sum += orders[i];
                if (sum<=quantityAvailable)
                {
                    queue.Dequeue();
                }
            }
            
            if (queue.Count > 0)
            {
                Console.WriteLine(bigestSell);
                Console.Write("Orders left: ");
                foreach (var order in queue)
                {
                    Console.Write($"{order} ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(bigestSell + Environment.NewLine + "Orders complete");
            }
        }
    }
}
