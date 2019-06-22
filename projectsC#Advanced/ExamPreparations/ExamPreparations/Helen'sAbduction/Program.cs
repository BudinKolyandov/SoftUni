using System;
using System.Text;

namespace Helen_sAbduction
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int rows = int.Parse(Console.ReadLine());

            char[][] field = new char[rows][];
            bool won = false;
            for (int i = 0; i < rows; i++)
            {
                field[i] = Console.ReadLine().ToCharArray();
            }
            int parisRow = 0;
            int parisCol = 0;
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    if (field[row][col] == 'P')
                    {
                        parisRow = row;
                        parisCol = col;
                    }
                }
            }

            while (energy > 0)
            {
                string[] commands = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string direction = commands[0].ToLower();
                int enemyRow = int.Parse(commands[1]);
                int enemyCol = int.Parse(commands[2]);

                field[enemyRow][enemyCol] = 'S';

                energy--;

                switch (direction)
                {
                    case "up":
                        if (parisRow - 1 >= 0)
                        {
                            field[parisRow][parisCol] = '-';
                            parisRow--;
                        }
                        break;
                    case "down":
                        if (parisRow + 1 < field.Length)
                        {
                            field[parisRow][parisCol] = '-';
                            parisRow++;
                        }
                        break;
                    case "left":
                        if (parisCol - 1 >= 0)
                        {
                            field[parisRow][parisCol] = '-';
                            parisCol--;
                        }
                        break;
                    case "right":
                        if (parisCol + 1 < field[parisRow].Length)
                        {
                            field[parisRow][parisCol] = '-';
                            parisCol++;
                        }
                        break;
                }

                if (field[parisRow][parisCol] == 'S')
                {
                    energy -= 2;
                    if (energy <=0)
                    {
                        field[parisRow][parisCol] = 'X';
                        break;
                    }
                    else
                    {
                        field[parisRow][parisCol] = 'P';
                    }
                }

                if (field[parisRow][parisCol] == 'H')
                {
                    won = true;
                    field[parisRow][parisCol] = '-';
                    break;
                }

                if (field[parisRow][parisCol] == '-')
                {
                    if (energy<=0)
                    {
                        field[parisRow][parisCol] = 'X';
                    }
                    else
                    {
                        field[parisRow][parisCol] = 'P';
                    }
                    
                }
            }

            if (won)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
                for (int row = 0; row < field.Length; row++)
                {
                    for (int col = 0; col < field[row].Length; col++)
                    {
                        Console.Write(field[row][col]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                for (int row = 0; row < field.Length; row++)
                {
                    for (int col = 0; col < field[row].Length; col++)
                    {
                        Console.Write(field[row][col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
