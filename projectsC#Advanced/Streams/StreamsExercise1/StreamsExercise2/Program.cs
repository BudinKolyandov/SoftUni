using System;
using System.IO;
using System.Linq;

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
                    letters = currentLine.Count(char.IsLetter);
                    punctuations = currentLine.Count(char.IsPunctuation);
                    File.AppendAllText("Output.txt", $"Line {count}: {currentLine} ({letters})/({punctuations}){Environment.NewLine}");
                    
                    letters = 0;
                    punctuations = 0;

                    currentLine = sr.ReadLine();
                    count++;
                }
            }
        }
    }
}
