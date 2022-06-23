using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();

            int[] orders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (int order in orders)
            {
                queue.Enqueue(order);
            }
            Console.WriteLine(queue.Max());

            while (queue.Count != 0)
            {
                if (queue.Peek() > foodQuantity)
                {
                    break;
                }
                foodQuantity -= queue.Dequeue();
            }
            if (queue.Count != 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue.ToArray())}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
