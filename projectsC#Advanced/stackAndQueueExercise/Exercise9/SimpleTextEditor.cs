using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise9
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            Stack<string> commandsMade = new Stack<string>();
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "1")
                {
                    commandsMade.Push(text.ToString());
                    text.Append(input[1]);
                }
                if (input[0] =="2")
                {
                    int count = int.Parse(input[1]);
                    commandsMade.Push(text.ToString());
                    text.Remove(text.Length - count, count);
                }
                if (input[0] == "3")
                {
                    int count = int.Parse(input[1]);
                    Console.WriteLine(text[count - 1]);
                }
                if (input[0] == "4")
                {
                    text.Clear();
                    text.Append(commandsMade.Pop());
                }
            }



        }
    }
}
