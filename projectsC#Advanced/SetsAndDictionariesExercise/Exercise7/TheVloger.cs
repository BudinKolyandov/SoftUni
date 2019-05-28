using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise7
{
    class TheVloger
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] commands = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = commands[1];
                if (command == "joined")
                {
                    string username = commands[0];
                    if (true)
                    {
                        if (!users.ContainsKey(username))
                        {
                            users.Add(username, new Dictionary<string, HashSet<string>>());
                            users[username].Add("following", new HashSet<string>());
                            users[username].Add("followers", new HashSet<string>());
                        }
                    }
                }
                else if (command == "followed")
                {
                    string username = commands[0];
                    string following = commands[2];
                    if (!users.ContainsKey(username) 
                        || !users.ContainsKey(following)
                        || username == following)
                    {
                        continue;
                    }
                    users[username]["following"].Add(following);
                    users[following]["followers"].Add(username);
                }
            }
            Console.WriteLine($"The V-Logger has a total of {users.Count} vloggers in its logs.");
            int count = 1;
            var sortedUsers = users
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["following"].Count)
                .ToDictionary(k => k.Key, v => v.Value);
            foreach (var (username, value) in sortedUsers)
            {
                int followers = sortedUsers[username]["followers"].Count;
                int following = sortedUsers[username]["following"].Count;
                Console.WriteLine($"{count}. {username} : {followers} followers, {following} following");
                if (count == 1)
                {
                    var usersFollowing = value["followers"].OrderBy(x => x).ToList();
                    foreach (var user in usersFollowing)
                    {
                        Console.WriteLine($"*  {user}");
                    }
                }
                count++;
            }
                                 
        }
    }
}
