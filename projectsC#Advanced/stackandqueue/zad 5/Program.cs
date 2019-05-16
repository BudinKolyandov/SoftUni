using System;
using System.Collections.Generic;

namespace zad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Queue <string>  queue = new Queue<string>();
            int count = 0;
            string command = Console.ReadLine();
            while (command.ToLower() != "end")
            {
                if (command.ToLower() == "green")
                {
                    int currentCount = queue.Count > n ? n : queue.Count;
                    for (int i = 0; i < currentCount; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
