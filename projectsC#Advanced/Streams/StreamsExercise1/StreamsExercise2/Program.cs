using System;
using System.IO;

namespace StreamsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathString = "../../../text.txt";
            int count = 1;
            int letters = 0;
            int punctuations = 0;
            StreamReader sr = new StreamReader(pathString);
            using (sr)
            {
                string currentLine = sr.ReadLine();
                while (currentLine != null)
                {
                    for (int i = 0; i < currentLine.Length; i++)
                    {
                        if (currentLine[i] == ' ')
                        {
                            continue;
                        }
                        else if (currentLine[i] == '-' || currentLine[i] == '.'|| currentLine[i] == ',' ||
                            currentLine[i] == '\'' || currentLine[i] == '!' || currentLine[i] == '?')
                        {
                            punctuations++;
                        }
                        else
                        {
                            letters++;
                        }
                    }
                    Console.WriteLine($"Line {count}: {currentLine} ({letters})/({punctuations})");
                    letters = 0;
                    punctuations = 0;

                    currentLine = sr.ReadLine();
                    count++;
                }
            }
        }
    }
}
