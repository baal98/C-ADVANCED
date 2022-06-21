using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int pushElement = inputs[0];
            int popElement = inputs[1];
            int searchedEllement = inputs[2];

            int[] inputsToPush = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            foreach (int input in inputsToPush)
            {
                queue.Enqueue(input);
            }
            for (int i = 0; i < popElement; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count > 0)
            {
                if (queue.Contains(searchedEllement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(queue.Count);
            }
        }
    }
}