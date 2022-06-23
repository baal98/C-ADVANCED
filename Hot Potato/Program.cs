using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split(' ');

            int numberOfToss = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            foreach (string kid in kids)
            {
                queue.Enqueue(kid);
            }
            int tempToss = numberOfToss;

            while (queue.Count != 1)
            {
                string removedKid = "";
                numberOfToss = tempToss;
                while (numberOfToss != 0)
                {
                    numberOfToss--;
                    removedKid = queue.Peek();
                    if (numberOfToss == 0)
                    {
                        break;
                    }
                    queue.Enqueue(queue.Dequeue());
                }
                queue.Dequeue();
                Console.WriteLine($"Removed {removedKid}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
