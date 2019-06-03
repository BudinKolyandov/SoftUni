using System;
using System.IO;
using System.Linq;
using System.Text;

namespace StreamsExercise1
{
    class EvenLines
    {
        static void Main(string[] args)
        {
            string pathString = "../../../text.txt";
            int count = 0;
            StreamReader sr = new StreamReader(pathString);
            using (sr)
            {
                string currentLine = sr.ReadLine();
                while (currentLine != null)
                {
                    string replaced = currentLine.Replace('-', '@').Replace(',','@').Replace('.','@')
                        .Replace('!', '@').Replace('?', '@');
                    if (count % 2 == 0)
                    {             
                        string[] newLine = replaced.Split().Reverse().ToArray();
                        Console.WriteLine(string.Join(' ', newLine));

                    }
                    currentLine = sr.ReadLine();
                    count++;
                }                    
            }
        }
    }
}
