using System;

namespace TronRacers
{
    class Program
    {
        static int firstPlayerRow;
        static int firstPlayerCol;

        static int secondPlayerRow;
        static int secondPlayerCol;

        static void Main(string[] args)
        {


            int size = int.Parse(Console.ReadLine());

            char[][] field = new char[size][];

            for (int i = 0; i < size; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                field[i] = input;
            }
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    if (field[row][col] == 'f')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                    }
                    if (field[row][col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;
                    }
                }
            }
            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                string firstDirection = commands[0];
                string secondDirection = commands[1];

                if (firstDirection == "down")
                {
                    firstPlayerRow++;
                    if (firstPlayerRow == field.Length)
                    {
                        firstPlayerRow = 0;
                    }
                }
                else if (firstDirection == "up")
                {
                    firstPlayerRow--;
                    if (firstPlayerRow < 0)
                    {
                        firstPlayerRow = field.Length - 1;
                    }
                }
               else if (firstDirection == "right")
                {
                    firstPlayerCol++;
                    if (firstPlayerCol == field[firstPlayerRow].Length)
                    {
                        firstPlayerCol = 0;
                    }
                }
                else if (firstDirection == "left")
                {
                    firstPlayerCol--;
                    if (firstPlayerCol < 0)
                    {
                        firstPlayerCol = field[firstPlayerRow].Length -1;
                    }
                }
                if (field[firstPlayerRow][firstPlayerCol] == 's')
                {
                    field[firstPlayerRow][firstPlayerCol] = 'x';
                    for (int row = 0; row < field.Length; row++)
                    {
                        for (int col = 0; col < field[row].Length; col++)
                        {
                            Console.Write(field[row][col]);
                        }
                        Console.WriteLine();
                    }
                    Environment.Exit(0);
                }
                else
                {
                    field[firstPlayerRow][firstPlayerCol] = 'f';
                }


                if (secondDirection == "down")
                {
                    secondPlayerRow++;
                    if (secondPlayerRow == field.Length)
                    {
                        secondPlayerRow = 0;
                    }
                }
                else if (secondDirection == "up")
                {
                    secondPlayerRow--;
                    if (secondPlayerRow < 0)
                    {
                        secondPlayerRow = field.Length - 1;
                    }
                }
                else if (secondDirection == "right")
                {
                    secondPlayerCol++;
                    if (secondPlayerCol == field[secondPlayerRow].Length)
                    {
                        secondPlayerCol = 0;
                    }
                }
                else if (secondDirection == "left")
                {
                    secondPlayerCol--;
                    if (secondPlayerCol < 0)
                    {
                        secondPlayerCol = field[secondPlayerRow].Length - 1;
                    }
                }
                if (field[secondPlayerRow][secondPlayerCol] == 'f')
                {
                    field[secondPlayerRow][secondPlayerCol] = 'x';
                    for (int row = 0; row < field.Length; row++)
                    {
                        for (int col = 0; col < field[row].Length; col++)
                        {
                            Console.Write(field[row][col]);
                        }
                        Console.WriteLine();
                    }
                    Environment.Exit(0);
                }
                else
                {
                    field[secondPlayerRow][secondPlayerCol] = 's';
                }


            }

        }
    }
}
