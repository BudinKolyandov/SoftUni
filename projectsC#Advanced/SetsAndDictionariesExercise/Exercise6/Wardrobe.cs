using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise6
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            var wardobe = new Dictionary<string, Dictionary<string, int>>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ");

                string color = input[0];

                if (!wardobe.ContainsKey(color))
                {
                    wardobe.Add(color, new Dictionary<string, int>());
                }
                string[] inputClothes = input[1].Split(',');
                foreach (var item in inputClothes)
                {
                    if (!wardobe[color].ContainsKey(item))
                    {
                        wardobe[color].Add(item, 0);
                    }
                    wardobe[color][item]++;
                }
            }

            string[] desiredCloth = Console.ReadLine()
                .Split();
            string desiredColor = desiredCloth[0];
            string desiredtype = desiredCloth[1];

            foreach (var (color, clothes) in wardobe)
            {
                Console.WriteLine($"{color} clothes:");
                foreach (var (cloth, value) in clothes)
                {
                    if (color == desiredColor && cloth == desiredtype)
                    {

                        Console.WriteLine($"* {cloth} - {value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth} - {value}");
                    }
                }
            }                                          
        }
    }
}
