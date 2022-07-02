using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPump = int.Parse(Console.ReadLine());

            Queue<int[]> queuePumps = new Queue<int[]>();

            for (int i = 0; i < numberOfPump; i++)
            {
                int[] pump = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                queuePumps.Enqueue(pump);
            }

            int counter = 0;

            while (queuePumps.Count != 0)
            {
                int totalSumPetrol = 0;
                bool isTourComplete = true;

                foreach (var q in queuePumps)
                {
                    int pumpSumPetrol = q[0];
                    int pumpSumDistance = q[1];

                    totalSumPetrol += pumpSumPetrol;

                    if (totalSumPetrol - pumpSumDistance < 0)
                    {
                        counter++;
                        isTourComplete = false;
                        queuePumps.Enqueue(queuePumps.Dequeue());
                        break;
                    }
                    totalSumPetrol -= pumpSumDistance;
                }
                if (isTourComplete)
                {
                    Console.WriteLine(counter);
                    break;
                }

            }
        }
    }
}