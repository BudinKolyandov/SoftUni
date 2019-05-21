using System;
using System.Linq;

namespace MultidimensionalArraysExerscise1
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] array = new int[size, size];
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            for (int i = 0; i < size; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < row.Length; j++)
                {
                    array[i, j] = row[j];
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <size; j++)
                {
                    if (i == j)
                    {
                        Math.Abs(primaryDiagonalSum += array[i, j]);
                    }
                    if (i == size - j - 1)
                    {
                        Math.Abs(secondaryDiagonalSum += array[i, j]);
                    }
                }
            }
            int difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(difference);

        }
    }
}
