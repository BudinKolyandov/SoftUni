using System;
using System.Linq;

namespace ExcelFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            string[][] table = new string[rows][];
            string[][] changedTable = new string[0][];
            for (int i = 0; i < rows; i++)
            {
                table[i] = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            string[] commandLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string command = commandLine[0];
            string commandHeader = commandLine[1];
            if (command == "hide")
            {
                changedTable = new string[rows][];
                int indexToHide = 0;
                for (int i = 0; i < table[0].Length; i++)
                {
                    if (table[0][i] == commandHeader)
                    {
                        indexToHide = i;
                    }
                }
                changedTable = table.Select(arr => arr.Where((item, i) => i != indexToHide)
                          .ToArray())
                          .ToArray();
            }

            if (command == "sort")
            {
                changedTable = new string[rows][];
                string[][] currentTable = new string[rows - 1][];
                int headerToSort;
                for (int i = 0; i < table[0].Length; i++)
                {                    
                    if (table[0][i] == commandHeader)
                    {
                        headerToSort = i;
                        string[] firstRow = table[0];
                        for (int row = 1; row < table.GetLength(0); row++)
                        {
                            currentTable[row-1] = table[row];
                        }
                        currentTable = currentTable.OrderBy(x => x[headerToSort]).ToArray().ToArray();                        
                    }
                    changedTable[0] = table[0];
                    for (int row = 0; row < currentTable.Length; row++)
                    {
                        changedTable[row + 1] = currentTable[row];
                    }
                    
                }
                
             }
            if (command == "filter")
            {
                string headerValue = commandLine[2];
                int headerIndex = 0;
                string[] firstRow = table[0];
                for (int i = 0; i < table[0].Length; i++)
                {
                    if (table[0][i] == commandHeader)
                    {
                        headerIndex = i;
                    }
                }
                int count = 0;
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    if (table[i][headerIndex] == headerValue)
                    {
                        count++;
                    }
                }
                changedTable = new string[count+1][];
                changedTable[0] = firstRow;
                count = 0;
                for (int i = 0; i < table.GetLength(0); i++)
                {
                    if (table[i][headerIndex] == headerValue)
                    {
                        changedTable[count+1] = table[i];
                        count++;
                    }
                }
            }
                


            for (int row = 0; row < changedTable.GetLength(0); row++)
            {
                
                Console.WriteLine(string.Join(" | ", changedTable[row]));
            }
        }
    }
}
