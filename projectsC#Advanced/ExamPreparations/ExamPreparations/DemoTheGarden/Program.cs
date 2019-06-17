using System;
using System.Linq;

namespace DemoTheGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            string[][] garden = new string[rows][];
            for (int i = 0; i < rows; i++)
            {
                string [] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int cols = input.Length;
                garden[i] = new string[cols];
                for (int j = 0; j < cols; j++)
                {
                    garden[i][j] = input[j];
                }
            }

            int carrots = 0;
            int potatoes = 0;
            int lettuce = 0;
            int harmedVegetables = 0;

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "End of Harvest")
            {
                string[] currentCommand = commands.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = currentCommand[0];

                if (command == "Harvest")
                {
                    int row = int.Parse(currentCommand[1]);
                    int col = int.Parse(currentCommand[2]);
                    if (row >= 0 && row < garden.Length
                        && col>=0 && col <garden[row].Length)
                    {
                        string charToHarvest = garden[row][col];
                        switch (charToHarvest)
                        {
                            case "C":
                                carrots++;
                                garden[row][col] = " ";
                                break;
                            case "p":
                                potatoes++;
                                garden[row][col] = " ";
                                break;
                            case "L":
                                lettuce++;
                                garden[row][col] = " ";
                                break;
                        }
                    }
                }
                if (command == "Mole")
                {
                    int row = int.Parse(currentCommand[1]);
                    int col = int.Parse(currentCommand[2]);
                    string direction = currentCommand[3];

                    if (row >= 0 && row < garden.Length
                        && col >= 0 && col < garden[row].Length)
                    {
                        switch (direction)
                        {
                            case "up":
                                for (int i = row; i >= 0; i -= 2)
                                {
                                    if (col < garden[i].Length)
                                    {
                                        if (garden[i][col] != " ")
                                        {
                                            harmedVegetables++;
                                            garden[i][col] = " ";
                                        }
                                        else
                                        {
                                            break;
                                        }                                    
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            case "down":
                                for (int i = row; i < garden.Length; i += 2)
                                {
                                    if (col < garden[i].Length)
                                    {
                                        if (garden[i][col] != " ")
                                        {
                                            harmedVegetables++;
                                            garden[i][col] = " ";
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            case "left":
                                for (int i = col; i >= 0; i -= 2)
                                {
                                    if (garden[row][i] != " ")
                                    {
                                        harmedVegetables++;
                                        garden[i][col] = " ";
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                            case "right":
                                for (int i = col; i < garden[row].Length; i += 2)
                                {
                                    if (garden[row][i] != " ")
                                    {
                                        harmedVegetables++;
                                        garden[row][i] = " ";
                                    }
                                    else
                                    {
                                        break;
                                    }    
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            foreach (var row in garden)
            {
                Console.WriteLine(string.Join(' ', row));
            }
            Console.WriteLine($"Carrots: {carrots}");
            Console.WriteLine($"Potatoes: {potatoes}");
            Console.WriteLine($"Lettuce: {lettuce}");
            Console.WriteLine($"Harmed vegetables: {harmedVegetables}");
        }
    }
}
