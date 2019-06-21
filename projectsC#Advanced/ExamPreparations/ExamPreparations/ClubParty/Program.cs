using System;
using System.Collections.Generic;
using System.Linq;

namespace ClubParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Stack<string> reservations = new Stack<string>();
            Queue<string> halls = new Queue<string>();
            List<int> currentHallReservations = new List<int>();
            
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                reservations.Push(input[i]);
            }
            
            int currentCapacity = 0;

            while (reservations.Count > 0)
            {
                int currentReservation = 0;
                string current = reservations.Pop();
                bool isNum = int.TryParse(current, out currentReservation);
                if (isNum == false)
                {
                    halls.Enqueue(current);
                }
                else
                {
                    if (halls.Count == 0)
                    {
                        continue;
                    }
                    if (currentCapacity + currentReservation > capacity)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", currentHallReservations)}");
                        currentHallReservations.Clear();
                        currentCapacity = 0;

                    }

                    if (halls.Count > 0)
                    {
                        currentHallReservations.Add(currentReservation);
                        currentCapacity += currentReservation;
                    }
                    
                }
            }


        }   
    }
}
