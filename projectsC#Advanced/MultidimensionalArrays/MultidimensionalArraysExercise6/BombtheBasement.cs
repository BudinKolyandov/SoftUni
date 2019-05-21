using System;
using System.Linq;

namespace MultidimensionalArraysExercise6
{
    class BombtheBasement
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] array = new int [size[0], size[1]];
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    array[i, j] = 0;
                }
            }
            int[] cordinates = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int targetRow = cordinates[0];
            int targetCol = cordinates[1];
            int radius = cordinates[2];
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    bool isInRadius = Math.Pow(row - targetRow, 2) + 
                        Math.Pow(col - targetCol, 2) <= Math.Pow(radius, 2);
                    if (isInRadius)
                    {
                        array[row, col] = 1;
                    }
                }
            }
            for (int col = 0; col < array.GetLength(1); col++)
            {
                int count = 0;
                for (int row = 0; row < array.GetLength(0); row++)
                {
                    if (array[row, col] == 1)
                    {
                        count++;
                        array[row, col] = 0;
                    }
                }
                for (int row = 0; row < count; row++)
                {
                    array[row, col] = 1;
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
