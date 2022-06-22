using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> bottleCapacity = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bottleCapacity.Reverse();

            Queue<int> queueCups = new Queue<int>();
            Queue<int> queueBottles = new Queue<int>();
            
            foreach (int cup in cupsCapacity)
            {
                queueCups.Enqueue(cup);
            }
            foreach (int bottle in bottleCapacity)
            {
                queueBottles.Enqueue(bottle);
            }
            int wastedWater = 0;
            int currentBotlle = 0;
            int currentCup = 0;

            while (queueCups.Count > 0 && queueBottles.Count > 0)
            {
                if  (currentCup > 0)
                {
                    currentBotlle = queueBottles.Dequeue();
                }
                else
                {
                    currentBotlle = queueBottles.Dequeue();
                    currentCup = queueCups.Peek();
                }

                if ((currentBotlle - currentCup) > 0)
                {
                    wastedWater += currentBotlle - currentCup;
                    currentCup = 0;
                    queueCups.Dequeue();
                }
                else if ((currentBotlle - currentCup) == 0)
                {
                    currentCup = 0;
                    queueCups.Dequeue();
                }
                else
                {
                    currentCup -= currentBotlle;
                }

            }
            if (queueBottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", queueBottles)}");
            }
            else if (queueCups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", queueCups)}");
            }
            
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
