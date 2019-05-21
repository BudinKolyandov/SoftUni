using System;
using System.Linq;

namespace MultidimensionalArraysExerscise3
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] array = new int[size[0], size[1]];
            for (int i = 0; i < size[0]; i++)
            {
                int [] row = Console.ReadLine().
                    ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    array[i, j] = row[j];
                }
            }
            int maxSum = int.MinValue;
            int selectedRow = -1;
            int selectedCol = -1;
            for (int row = 0; row < array.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < array.GetLength(1) - 2; col++)
                {
                    int sum = array[row, col] + array[row, col + 1]
                        + array[row, col + 2] + array[row + 1, col]
                        + array[row + 1, col + 1] + array[row + 1, col + 2]
                        + array[row + 2, col] + array[row + 2, col + 1]
                        + array[row + 2, col + 2];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        selectedCol = col;
                        selectedRow = row;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{array[selectedRow,selectedCol]} {array[selectedRow, selectedCol +1]}" +
                $" {array[selectedRow, selectedCol + 2]} \n{array[selectedRow + 1, selectedCol]} " +
                $"{array[selectedRow + 1, selectedCol + 1]} {array[selectedRow + 1, selectedCol + 2]}" +
                $"\n{array[selectedRow+ 2, selectedCol]} {array[selectedRow + 2, selectedCol + 1]} " +
                $"{array[selectedRow + 2, selectedCol + 2]}");


        }
    }
}
