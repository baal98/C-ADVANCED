using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack stack = new Stack();

            foreach (int digit in digits)
            {
                stack.Push(digit);
            }
            string command;

            while ((command = Console.ReadLine().ToUpper()) != "END")
            {
                string[] inputs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = inputs[0];

                if (action == "ADD")
                {
                    int firstDigit = int.Parse(inputs[1]);
                    int secondDigit = int.Parse(inputs[2]);
                    stack.Push(firstDigit);
                    stack.Push(secondDigit);
                }
                else if (action == "REMOVE")
                {
                    int digitsToRemove = int.Parse(inputs[1]);

                    if (digitsToRemove >= stack.Count)
                    {
                        continue;
                    }
                    for (int i = 0; i < digitsToRemove; i++)
                    {
                        stack.Pop();
                    }
                }
            }
            int sumOfDigits = 0;

            foreach (var digit in stack)
            {
                sumOfDigits += (int)digit;
            }
            Console.WriteLine($"Sum: {sumOfDigits}");
        }
    }
}
