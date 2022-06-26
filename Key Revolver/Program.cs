using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> stackBulllets = new Stack<int>();
            foreach (var bullet in bullets)
            {
                stackBulllets.Push(bullet);
            }
            int totalBullets = stackBulllets.Count;
            Queue<int> queueLocks = new Queue<int>();

            foreach (var lock_ in locks)
            {
                queueLocks.Enqueue(lock_);
            }

            int tempGunBarrelSize = gunBarrelSize;
            bool isUnlocked = false;

            while (stackBulllets.Count != 0)
            {
                gunBarrelSize = tempGunBarrelSize;
                while (gunBarrelSize > 0)
                {
                    gunBarrelSize--;
                    
                    int bullet = stackBulllets.Pop();
                    int lock_ = queueLocks.Peek();
                    
                    if (bullet <= lock_)
                    {
                        queueLocks.Dequeue();
                        Console.WriteLine("Bang!");
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                    if (stackBulllets.Count == 0)
                    {
                        continue;
                    }
                    if (queueLocks.Count == 0)
                    {
                        isUnlocked = true;
                        break;
                    }
                }
                if (stackBulllets.Count == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Reloading!");
                    if (isUnlocked)
                    {
                        break;
                    }
                }

            }
            if (isUnlocked)
            {
                Console.WriteLine($"{stackBulllets.Count} bullets left. Earned ${intelligence - (totalBullets - stackBulllets.Count) * bulletPrice}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
            }
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _11._Key_Revolver
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int priceForSingleBullet = int.Parse(Console.ReadLine());
//            int gunBarrelSize = int.Parse(Console.ReadLine());
//            var bulletsCount = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
//            int[] locksCount = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
//            int InteligencePrice = int.Parse(Console.ReadLine());
//            bulletsCount.Reverse();

//            Queue<int> locks = new Queue<int>(locksCount);
//            Queue<int> bullets = new Queue<int>(bulletsCount);

//            int currentBarrel = gunBarrelSize;
//            int bulletCounts = 0;

//            while (bullets.Count > 0 && locks.Count > 0)
//            {
//                var currentLock = locks.Peek();
//                var currentBullet = bullets.Dequeue();
//                currentBarrel--;
//                bulletCounts++;

//                if (currentLock < currentBullet)
//                {
//                    Console.WriteLine("Ping!");
//                }
//                else
//                {
//                    Console.WriteLine("Bang!");
//                    locks.Dequeue();
//                }

//                if (currentBarrel == 0 && bullets.Count > 0)
//                {
//                    currentBarrel = gunBarrelSize;
//                    Console.WriteLine("Reloading!");
//                }
//            }



//            if (locks.Count > 0)
//            {
//                int locksLeft = locks.Count;
//                Console.WriteLine($"Couldn't get through. Locks left: {locksLeft}");
//            }
//            else
//            {
//                int moneyEarned = InteligencePrice - (bulletCounts * priceForSingleBullet);
//                int bulletsLeft = bullets.Count;
//                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${moneyEarned}");
//            }
//        }
//    }
//}
