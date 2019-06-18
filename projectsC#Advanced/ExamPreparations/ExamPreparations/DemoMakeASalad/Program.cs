using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoMakeASalad
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> calories = new Stack<int>();
            Queue<string> vegetables = new Queue<string>();
            List<int> salads = new List<int>();

            string[] vegetablesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int[] caloriesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var vegetable in vegetablesInput)
            {
                vegetables.Enqueue(vegetable);
            }

            foreach (var calorie in caloriesInput)
            {
                calories.Push(calorie);
            }

            int currentCount = calories.Count;

            for (int i = 0; i < currentCount; i++)
            {
                int currentCalories = calories.Peek();
                while (currentCalories > 0)
                {
                    if (vegetables.Count == 0)
                    {
                        break;
                    }
                    string currentVegetable = vegetables.Peek().ToLower();
                    switch (currentVegetable)
                    {
                        case "tomato":
                            currentCalories -= 80;
                            break;
                        case "carrot":
                            currentCalories -= 136;
                            break;
                        case "lettuce":
                            currentCalories -= 109;
                            break;
                        case "potato":
                            currentCalories -= 215;
                            break;
                    }
                    vegetables.Dequeue();
                }
                int saladMade = calories.Peek();
                salads.Add(saladMade);
                calories.Pop();
                if (vegetables.Count == 0)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(' ', salads));
            if (vegetables.Count > 0)
            {
                Console.WriteLine(string.Join(' ', vegetables));
            }
            if (calories.Count > 0)
            {
                Console.WriteLine(string.Join(' ', calories));
            }
        }
    }
}
