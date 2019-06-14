using System;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> leftSocks = new Stack<int>();
            Queue<int> rightSocks = new Queue<int>();

            List<int> pairs = new List<int>();

            int[] leftSocksArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] rightSocksArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            foreach (var sock in leftSocksArray)
            {
                leftSocks.Push(sock);
            }
            foreach (var sock in rightSocksArray)
            {
                rightSocks.Enqueue(sock);
            }

            while (leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                int currentLeftSock = leftSocks.Peek();
                int currentRightSock = rightSocks.Peek();

                if (currentLeftSock > currentRightSock)
                {
                    int pair = currentLeftSock + currentRightSock;
                    pairs.Add(pair);
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                    continue;
                }

                if (currentRightSock > currentLeftSock)
                {
                    leftSocks.Pop();
                    continue;
                }

                if (currentRightSock == currentLeftSock)
                {
                    rightSocks.Dequeue();
                    leftSocks.Pop();
                    leftSocks.Push(currentLeftSock + 1);
                    continue;
                }
            }

            int biggestSet = int.MinValue;

            foreach (var pair in pairs)
            {
                if (biggestSet < pair)
                {
                    biggestSet = pair;
                }
            }

            Console.WriteLine(biggestSet);
            Console.WriteLine(string.Join(' ', pairs));
        }
    }
}
