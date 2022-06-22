using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int windowDuration = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            string command;
            int counter = 0;
            int tempGreenLightDuration = greenLightDuration;
            int tempWindowDuration = windowDuration;

            while ((command = Console.ReadLine()) != "END")
            {
                greenLightDuration = tempGreenLightDuration;
                tempWindowDuration = windowDuration;

                if (command == "green" && queue.Count > 0)
                {

                    int carLength = queue.Peek().Length;
                    while (greenLightDuration > 0)
                    {
                        carLength = queue.Peek().Length;
                        if (carLength > greenLightDuration)
                        {
                            carLength -= greenLightDuration;
                            if (carLength <= windowDuration)
                            {
                                counter++;
                                queue.Dequeue();
                                break;
                            }
                            else
                            {
                                carLength -= windowDuration;
                                char hitPointChar = queue.Peek().ElementAt(greenLightDuration + windowDuration);
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{queue.Peek()} was hit at {hitPointChar}.");
                                return;
                            }
                        }
                        counter++;
                        greenLightDuration -= carLength;
                        queue.Dequeue();
                        if (queue.Count == 0)
                        {
                            break;
                        }
                    }
                }
                else if (!(command == "green"))
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine("Everyone is safe.");

            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
