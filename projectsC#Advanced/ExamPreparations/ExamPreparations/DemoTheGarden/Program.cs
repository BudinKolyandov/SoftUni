using System;
using System.Linq;

namespace DemoTheGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] garden = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse).ToArray();
                garden[i] = input;
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
                        && col >= 0 && col < garden[row].Length)
                    {
                        char charToHarvest = garden[row][col];
                        if (charToHarvest != ' ')
                        {
                            switch (charToHarvest)
                            {
                                case 'C':
                                    carrots++;
                                    garden[row][col] = ' ';
                                    break;
                                case 'P':
                                    potatoes++;
                                    garden[row][col] = ' ';
                                    break;
                                case 'L':
                                    lettuce++;
                                    garden[row][col] = ' ';
                                    break;
                            }
                        }                        
                    }
                }
                if (command == "Mole")
                {
                    int row = int.Parse(currentCommand[1]);
                    int col = int.Parse(currentCommand[2]);
                    string direction = currentCommand[3].ToLower();

                    if (row >= 0 && row < garden.Length
                        && col >= 0 && col < garden[row].Length)
                    {
                        if (direction == "up")
                        {
                            for (int currentRow = row; currentRow >= 0; currentRow-=2)
                            {
                                if (currentRow >= 0 && currentRow < garden.Length
                                    && col >= 0 && col < garden[row].Length
                                    && garden[currentRow][col] != ' ')
                                {
                                    garden[currentRow][col] = ' ';
                                    harmedVegetables += 1;
                                }
                            }
                        }
                        else if (direction == "down")
                        {
                            for (int currentRow = row; currentRow < garden.Length; currentRow+=2)
                            {
                                if (currentRow >= 0 && currentRow < garden.Length
                                    && col >= 0 && col < garden[row].Length
                                    && garden[currentRow][col] != ' ')
                                {
                                    garden[currentRow][col] = ' ';
                                    harmedVegetables += 1;
                                }
                            }
                        }
                        else if (direction == "left")
                        {
                            for (int currentCol = col; currentCol >= 0; currentCol-=2)
                            {
                                if (row >= 0 && row < garden.Length
                                    && currentCol >=0 && currentCol < garden[row].Length
                                    && garden[row][currentCol] != ' ')
                                {
                                    garden[row][currentCol] = ' ';
                                    harmedVegetables += 1;
                                }
                            }
                        }
                        else if (direction == "right")
                        {
                            for (int currentCol = col; currentCol <garden[row].Length; currentCol+=2)
                            {
                                if (row >= 0 && row < garden.Length
                                    && currentCol >= 0 && currentCol < garden[row].Length
                                    && garden[row][currentCol] != ' ')
                                {
                                    garden[row][currentCol] = ' ';
                                    harmedVegetables += 1;
                                }
                            }
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