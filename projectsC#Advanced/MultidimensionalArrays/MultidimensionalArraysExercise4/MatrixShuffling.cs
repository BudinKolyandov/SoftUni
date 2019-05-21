using System;
using System.Linq;

namespace MultidimensionalArraysExercise4
{
    class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] array = new string [size[0], size[1]];
            for (int i = 0; i < size[0]; i++)
            {
                string [] row = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    array[i, j] = row[j];
                }
            }
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandCordinates = command.Split();
                if (commandCordinates.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                if (commandCordinates[0] == "swap")
                {
                    int row1 = int.Parse(commandCordinates[1]);
                    int col1 = int.Parse(commandCordinates[2]);
                    int row2 = int.Parse(commandCordinates[3]);
                    int col2 = int.Parse(commandCordinates[4]);
                    if (array.GetLength(0) > row1 && array.GetLength(0) > row2)
                    {
                        string variable = array[row2, col2];
                        array[row2, col2] = array[row1, col1];
                        array[row1, col1] = variable;
                        for (int row = 0; row < array.GetLength(0); row++)
                        {
                            for (int col = 0; col < array.GetLength(1); col++)
                            {
                                Console.Write("{0} ", array[row, col]);
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }




        }
    }
}
