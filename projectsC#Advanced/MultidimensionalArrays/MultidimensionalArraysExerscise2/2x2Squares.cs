using System;
using System.Linq;

namespace MultidimensionalArraysExerscise2
{
    class Squares2x2
    {
        static void Main(string[] args)
        {            
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] array = new char[size[0], size[1]];
            for (int i = 0; i < size[0]; i++)
            {
                char[] row = Console.ReadLine().
                    ToLower()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    array[i, j] = row[j];
                }
            }
            int squareMatrixes = 0;
            for (int row = 0; row < array.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < array.GetLength(1) - 1; col++)
                {
                    if (array[row, col] == array[row, col + 1] 
                        && array[row, col] == array[row + 1, col]
                        && array[row, col] == array[row + 1, col + 1])
                    {
                        squareMatrixes++;
                    }
                }
            }
            Console.WriteLine(squareMatrixes);


        }
    }
}
