using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Paid")
                {
                    while (queue.Count != 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
