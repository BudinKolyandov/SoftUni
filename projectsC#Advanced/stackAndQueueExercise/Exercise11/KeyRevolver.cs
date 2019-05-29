using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise11
{
    class KeyRevolver
    {
        static void Main(string[] args)
        {
            Stack<int> bullets = new Stack<int>();
            Queue<int> locks = new Queue<int>();
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int currentBarrelSize = barrelSize;
            int bulletsFired = 0;
            int[] bulletsArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] locksArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int valueOfIntelegence = int.Parse(Console.ReadLine());
            foreach (var bullet in bulletsArray)
            {
                bullets.Push(bullet);
            }
            foreach (var lockToEnqueue in locksArray)
            {
                locks.Enqueue(lockToEnqueue);
            }
            int count = bullets.Count;
            for (int i = 0; i < count; i++)
            {
                if (bullets.Count > 0 && locks.Count > 0)
                {
                    int currentBullet = bullets.Peek();
                    int currentLock = locks.Peek();
                    if (currentBullet <= currentLock)
                    {
                        Console.WriteLine("Bang!");
                        bullets.Pop();
                        locks.Dequeue();
                        currentBarrelSize--;
                        bulletsFired++;
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                        bullets.Pop();
                        currentBarrelSize--;
                        bulletsFired++;
                    }
                    if (currentBarrelSize == 0 && bullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        currentBarrelSize = barrelSize;
                    }
                }
            }
            int costForFiredBullets = bulletsFired * bulletPrice;
            int moneyEarned = valueOfIntelegence - costForFiredBullets;
            if (bullets.Count >= 0 && locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }

        }
    }
}
