using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            
            while (numberOfInputs != 0)
            {
                string[] commands = Console.ReadLine().Split(' ');

                string action = commands[0];

                if (action == "1")
                {
                    int ellement = int.Parse(commands[1]);
                    stack.Push(ellement);
                }
                else if (action == "2")
                {
                    if (!(stack.Count == 0))
                    {
                        stack.Pop();
                    }
                }
                else if (action == "3")
                {
                    if (!(stack.Count == 0))
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (action == "4")
                {
                    if (!(stack.Count == 0))
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
                numberOfInputs--;
            }
            Console.WriteLine(string.Join(", ", stack.ToArray()));
        }
    }
}
