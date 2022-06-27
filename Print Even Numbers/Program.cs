using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue queue = new Queue();

            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] % 2 == 0)
                {
                    queue.Enqueue(inputs[i]);
                }
            }

            while (queue.Count != 0)
            {
                if (queue.Count == 1)
                {
                    Console.Write(queue.Dequeue());
                    break;
                }
                Console.Write($"{queue.Dequeue()}, ");
            }
           
            
        }
    }
}
