using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var participants = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;
            while ((input= Console.ReadLine()) != "end of contests")
            {
                string[] contestInfo = input.Split(':');
                if (!contests.ContainsKey(contestInfo[0]))
                {
                    contests.Add(contestInfo[0], contestInfo[1]);
                }
            }
            while ((input = Console.ReadLine()) != "end of submissions")
            {                
                string[] submissionInfo = input.Split("=>");
                string contestName = submissionInfo[0];
                string contestPassword = submissionInfo[1];
                string userName = submissionInfo[2];
                int points = int.Parse(submissionInfo[3]);
                if (!contests.ContainsKey(contestName) 
                    || contests[contestName] != contestPassword)
                {
                    continue;
                }
                if (!participants.ContainsKey(userName))
                {
                    participants.Add(userName, new Dictionary<string, int>());
                }
                if (!participants[userName].ContainsKey(contestName))
                {
                    participants[userName].Add(contestName, 0);
                }
                if (participants[userName][contestName] < points)
                {
                    participants[userName][contestName] = points;
                }
            }
            var best = participants
                .OrderByDescending(v => v.Value.Values.Sum(x => x))
                .FirstOrDefault();
            var bestPoints = best.Value.Values.Sum(x => x);
            Console.WriteLine($"Best candidate is {best.Key} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var (key, value) in participants.OrderBy(x => x.Key))
            {
                Console.WriteLine(key);
                foreach (var (contestName, points) in value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contestName} -> {points}");
                }
            }




        }
    }
}
