using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05_GreedyTimes
{
    class Execution
    {
        public void Run()
        {

            long input = long.Parse(Console.ReadLine());
            string[] safeContents = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bagContent = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long gems = 0;
            long money = 0;

            for (int i = 0; i < safeContents.Length; i += 2)
            {
                string kindOfTressure = safeContents[i];
                long count = long.Parse(safeContents[i + 1]);

                string currentTressure = string.Empty;

                currentTressure = DefiningTressure(kindOfTressure, currentTressure);

                if (currentTressure == "")
                {
                    continue;
                }
                else if (input < bagContent.Values.Select(x => x.Values.Sum()).Sum() + count)
                {
                    continue;
                }

                switch (currentTressure)
                {
                    case "Gem":
                        if (!bagContent.ContainsKey(currentTressure))
                        {
                            if (bagContent.ContainsKey("Gold"))
                            {
                                if (count > bagContent["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bagContent[currentTressure].Values.Sum() + count > bagContent["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bagContent.ContainsKey(currentTressure))
                        {
                            if (bagContent.ContainsKey("Gem"))
                            {
                                if (count > bagContent["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bagContent[currentTressure].Values.Sum() + count > bagContent["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                FillingBag(bagContent, ref gold, ref gems, ref money, kindOfTressure, count, currentTressure);
            }

            GeneratingOutput(bagContent);
        }

        private static void FillingBag(Dictionary<string, Dictionary<string, long>> bagContent, ref long gold, ref long gems, ref long money, string kindOfTressure, long count, string currentTressure)
        {
            if (!bagContent.ContainsKey(currentTressure))
            {
                bagContent[currentTressure] = new Dictionary<string, long>();
            }

            if (!bagContent[currentTressure].ContainsKey(kindOfTressure))
            {
                bagContent[currentTressure][kindOfTressure] = 0;
            }

            bagContent[currentTressure][kindOfTressure] += count;
            if (currentTressure == "Gold")
            {
                gold += count;
            }
            else if (currentTressure == "Gem")
            {
                gems += count;
            }
            else if (currentTressure == "Cash")
            {
                money += count;
            }
        }

        private static void GeneratingOutput(Dictionary<string, Dictionary<string, long>> bagContent)
        {
            foreach (var tresure in bagContent)
            {
                Console.WriteLine($"<{tresure.Key}> ${tresure.Value.Values.Sum()}");
                foreach (var typeOfTresure in tresure.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{typeOfTresure.Key} - {typeOfTresure.Value}");
                }
            }
        }

        private static string DefiningTressure(string kindOfTressure, string currentTressure)
        {
            if (kindOfTressure.Length == 3)
            {
                currentTressure = "Cash";
            }
            else if (kindOfTressure.ToLower().EndsWith("gem"))
            {
                currentTressure = "Gem";
            }
            else if (kindOfTressure.ToLower() == "gold")
            {
                currentTressure = "Gold";
            }

            return currentTressure;
        }
    }
}
