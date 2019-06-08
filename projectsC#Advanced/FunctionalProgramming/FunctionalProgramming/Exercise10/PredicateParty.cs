using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise10
{
    class PredicateParty
    {
        static void Main(string[] args)
        {
            List<string> goingToParty = Console.ReadLine()
                .Split()
                .ToList();

            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "Party!")
            {
                string[] commandsArray = commands.Split().ToArray();
                string command = commandsArray[0];
                string condition = commandsArray[1];

                if (command == "Remove")
                {
                    string criteria = commandsArray[2];
                    switch (condition)
                    {
                        case "StartsWith":
                            for (int i = goingToParty.Count - 1; i >= 0; i--)
                            {
                                if (goingToParty[i].StartsWith(criteria))
                                {
                                    goingToParty.Remove(goingToParty[i]);
                                }
                            }
                            break;
                        case "EndsWith":
                            for (int i = goingToParty.Count - 1; i >= 0; i--)
                            {
                                if (goingToParty[i].EndsWith(criteria))
                                {
                                    goingToParty.Remove(goingToParty[i]);
                                }
                            }
                            break;
                        case "Length":
                            for (int i = goingToParty.Count - 1; i >= 0; i--)
                            {
                                if (goingToParty[i].Length == int.Parse(criteria))
                                {
                                    goingToParty.Remove(goingToParty[i]);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                else if (command == "Double")
                {
                    string criteria = commandsArray[2];
                    switch (condition)
                    {
                        case "StartsWith":
                            for (int i = goingToParty.Count - 1; i >= 0; i--)
                            {
                                if (goingToParty[i].StartsWith(criteria))
                                {
                                    goingToParty.Insert(i + 1, goingToParty[i]);
                                }
                            }
                            break;
                        case "EndsWith":
                            for (int i = goingToParty.Count - 1; i >= 0; i--)
                            {
                                if (goingToParty[i].EndsWith(criteria))
                                {
                                    goingToParty.Insert(i + 1, goingToParty[i]);
                                }
                            }
                            break;
                        case "Length":
                            for (int i = goingToParty.Count - 1; i >= 0; i--)
                            {
                                if (goingToParty[i].Length == int.Parse(criteria))
                                {
                                    goingToParty.Insert(i + 1, goingToParty[i]);
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }

            }

            if (goingToParty.Any())
            {
                Console.WriteLine($"{string.Join(", ", goingToParty)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }


        }
    }
}
