using System;

namespace MultidimensionalArraysExercise7
{
    class KnightGame
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[,] board = new char[rows, rows];

            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < rows; col++)
                {
                    board[row, col] = input[col];
                }
            }
            int removedKnights = 0;
            while (true)
            {
                int maxAttack = 0;
                int knightRow = -1;
                int knightCol = -1;
                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int currentCount = 0;
                        if (board[row, col] == 'K')
                        {
                            if (IsInside(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }
                            if (IsInside(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                            {
                                currentCount++;
                            }
                        }
                        if (currentCount > maxAttack)
                        {
                            maxAttack = currentCount;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }

                if (maxAttack == 0)
                {
                    break;
                }
                board[knightRow, knightCol] = '0';
                removedKnights++;
            }
            Console.WriteLine(removedKnights);

        }

        private static bool IsInside(char[,] board, int neededRow, int neededCol)
        {
            return neededRow < board.GetLength(0) && neededRow >= 0
                && neededCol < board.GetLength(1) && neededCol >= 0;
        }
    }
}
