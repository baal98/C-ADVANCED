using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsToPass = int.Parse(Console.ReadLine());

            Queue queue = new Queue();
            int countOfPassedCars = 0;
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < carsToPass; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        countOfPassedCars++;
                        
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{countOfPassedCars} cars passed the crossroads.");
        }
    }
}
