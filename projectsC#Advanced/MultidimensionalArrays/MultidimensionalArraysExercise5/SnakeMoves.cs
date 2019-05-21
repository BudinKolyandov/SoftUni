using System;
using System.Collections.Generic;
using System.Linq;

namespace MultidimensionalArraysExercise5
{
    class SnakeMoves
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[] snake = Console.ReadLine().ToCharArray();
            Queue<char> queue = new Queue<char>(snake);
            char[,] array = new char[size[0], size[1]];
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    if (snake.Length == 0)
                    {
                        continue;
                    }
                    if (queue.Count >= size[1])
                    {
                        array[i, j] = queue.Dequeue();
                    }
                    else
                    {
                        foreach (var item in snake)
                        {
                            queue.Enqueue(item);
                        }
                        array[i, j] = queue.Dequeue();
                    }
                }
            }
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write("{0}", array[row, col]);
                }
                Console.WriteLine();
            }



        }
    }
}
