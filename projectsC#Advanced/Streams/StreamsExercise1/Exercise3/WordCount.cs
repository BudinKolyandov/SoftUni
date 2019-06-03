using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exercise3
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var wordsCount = new Dictionary<string, int>();
            string[] lines = File.ReadAllLines("../../../text.txt");
            string[] words = File.ReadAllLines("../../../words.txt");

            foreach (var word in words)
            {
                if (!wordsCount.ContainsKey(word.ToLower()))
                {
                    wordsCount.Add(word.ToLower(), 0);
                }
            }
            foreach (var line in lines)
            {
                string[] wordsInLine = line
                    .ToLower()
                    .Split(new char[] { ' ', ',', '?', '!', '.', '\'', ':', ';', '-' });
                foreach (var currentword in wordsInLine)
                {
                    if (wordsCount.ContainsKey(currentword))
                    {
                        wordsCount[currentword]++;
                    }
                }
            }           

            foreach (var (key, value) in wordsCount)
            {
                File.AppendAllText("../../../actualResult.txt", $"{key} - {value}" +
                    $"{Environment.NewLine}");
            }
            string[] expectedLines = File.ReadAllLines("../../../expectedResult.txt");
            string[] currentLines = new string[expectedLines.Length];
            int count = 0;
            foreach (var (key, value) in wordsCount.OrderByDescending(x => x.Value))
            {
                currentLines[count] = ($"{key} - {value}");
                count++;
            }
            count = 0;
            for (int i = 0; i < expectedLines.Length; i++)
            {
                if (expectedLines[i] == currentLines[i])
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} lines match!");
        }
    }
}
