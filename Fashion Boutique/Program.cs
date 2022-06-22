using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();
            foreach (int clothes in clothesInBox)
            {
                queue.Enqueue(clothes);
            }

            int counter = 0;
            int temp = rackCapacity;
            int queueCount = queue.Count;

            while (queue.Count != 0)
            {
                if (rackCapacity - queue.Peek() < 0)
                {
                    counter++;
                    rackCapacity = temp;
                }
                else if (queue.Count == 1)
                {
                    counter++;
                    queue.Dequeue();
                    break;
                }
                else
                {
                    rackCapacity -= queue.Dequeue();
                }
            }

            Console.WriteLine(counter);
        }
    }
}
