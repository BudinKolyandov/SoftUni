using System;
using System.Collections.Generic;
using System.Linq;

namespace TrojanInvasion
{
    class Program
    {
        static void Main(string[] args)
        {        
            int waves = int.Parse(Console.ReadLine());
            int[] platesInput = Console.ReadLine()
                .Split()                
                .Select(int.Parse)
                .ToArray();
            List<int> plates = new List<int>(platesInput);

            for (int i = 1; i <= waves; i++)
            {
                int[] currentWave = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 3 == 0)
                {
                    plates.Add(int.Parse(Console.ReadLine()));
                }
                Stack<int> warriors = new Stack<int>(currentWave);
                
                while (warriors.Count > 0 && plates.Count > 0)
                {
                    int currentWarrior = warriors.Pop();
                    int currentPlate = plates[0];

                    if (currentWarrior > currentPlate )
                    {
                        currentWarrior -= currentPlate;
                        warriors.Push(currentWarrior);
                        plates.RemoveAt(0);
                    }
                    else if(currentWarrior < currentPlate)
                    {
                        currentPlate -= currentWarrior;
                        plates[0] = currentPlate;
                    }
                    else
                    {
                        plates.RemoveAt(0);
                    }


                    if (plates.Count == 0)
                    {
                        Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                        if (warriors.Count > 0)
                        {
                            Console.WriteLine($"Warriors left: {string.Join(", ", warriors)}");
                        }
                        Environment.Exit(0);
                    }
                    
                }

            }
            Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
            if (plates.Count > 0)
            {
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            Environment.Exit(0);

        }
    }
}
