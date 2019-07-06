using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03_JediGalaxy
{
    class Execution
    {
        public long sum = 0;

        public void Run()
        {
            int[] dimestions = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = InitializeMatrix(dimestions);

            string command = Console.ReadLine();

            while (command != "Let the Force be with you")
            {
                int[] player = command
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int[] evil = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int evilRow = evil[0];
                int evilCol = evil[1];
                EvilMovement(ref matrix, evilRow, evilCol);

                int playerRow = player[0];
                int playerCol = player[1];

                PlayerMovement(ref matrix, playerRow, playerCol);

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
            
        }

        private void PlayerMovement(ref int[,] matrix, int playerRow, int playerCol)
        {
            while (playerRow >= 0 && playerCol < matrix.GetLength(1))
            {
                if (IsInside(matrix, playerRow, playerCol))
                {
                    sum += matrix[playerRow, playerCol];
                }

                playerCol++;
                playerRow--;
            }
        }

        private static void EvilMovement(ref int[,] matrix, int evilRow, int evilCol)
        {
            while (evilRow >= 0 && evilCol >= 0)
            {
                if (IsInside(matrix, evilRow, evilCol))
                {
                    matrix[evilRow, evilCol] = 0;
                }
                evilRow--;
                evilCol--;
            }
        }

        private static bool IsInside(int[,] matrix, int targetRow, int TargetCol)
        {
            return targetRow >= 0 && targetRow < matrix.GetLength(0)
                && TargetCol >= 0 && TargetCol < matrix.GetLength(1);
        }

        private static int[,] InitializeMatrix(int[] dimestions)
        {
            int rows = dimestions[0];
            int cols = dimestions[1];

            int[,] matrix = new int[rows, cols];

            int value = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = value++;
                }
            }

            return matrix;
        }
    }
}
