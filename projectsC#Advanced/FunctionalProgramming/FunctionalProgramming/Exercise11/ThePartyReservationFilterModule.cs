using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise11
{
    class ThePartyReservationFilterModule
    {
        static void Main(string[] args)
        {
            List<string> goingToParty = Console.ReadLine()
                .Split()
                .ToList();

            List<string> startsWith = new List<string>();
            List<string> endsWith = new List<string>();
            List<string> contains = new List<string>();
            List<int> length = new List<int>();

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "Print")
            {
                string[] commandsArray = commands.Split(';').ToArray();
                string command = commandsArray[0];
                string filterType = commandsArray[1];
                string filterParameter = commandsArray[2];
                if (command == "Add filter")
                {
                    switch (filterType)
                    {
                        case "Starts with":
                            startsWith.Add(filterParameter);
                            break;
                        case "Ends with":
                            endsWith.Add(filterParameter);
                            break;
                        case "Length":
                            length.Add(int.Parse(filterParameter));
                            break;
                        case "Contains":
                            contains.Add(filterParameter);
                            break;
                        default:
                            break;
                    }
                }
                if (command == "Remove filter")
                {
                    switch (filterType)
                    {
                        case "Starts with":
                            startsWith.Remove(filterParameter);
                            break;
                        case "Ends with":
                            endsWith.Remove(filterParameter);
                            break;
                        case "Length":
                            length.Remove(int.Parse(filterParameter));
                            break;
                        case "Contains":
                            contains.Remove(filterParameter);
                            break;
                        default:
                            break;
                    }
                }
            }
            foreach (var ch in startsWith)
            {
                for (int i = goingToParty.Count - 1; i >= 0; i--)
                {
                    if (goingToParty[i].StartsWith(ch))
                    {
                        goingToParty.Remove(goingToParty[i]);
                    }
                }
            }
            foreach (var ch in endsWith)
            {
                for (int i = goingToParty.Count - 1; i >= 0; i--)
                {
                    if (goingToParty[i].EndsWith(ch))
                    {
                        goingToParty.Remove(goingToParty[i]);
                    }
                }
            }
            foreach (var ch in contains)
            {
                for (int i = goingToParty.Count - 1; i >= 0; i--)
                {
                    if (goingToParty[i].Contains(ch))
                    {
                        goingToParty.Remove(goingToParty[i]);
                    }
                }
            }
            foreach (var size in length)
            {
                for (int i = goingToParty.Count - 1; i >= 0; i--)
                {
                    if (goingToParty[i].Length == size)
                    {
                        goingToParty.Remove(goingToParty[i]);
                    }
                }
            }
            
            Console.WriteLine($"{string.Join(" ", goingToParty)}");
        }
    }
}
