using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            Stack<string> stack = new Stack<string>();

            foreach (string input in inputs)
            {
                stack.Push(input);
            }
            int stackLength = stack.Count;
            int sum = int.Parse(stack.Pop());

            for (int i = 0; i < stackLength; i++)
            {
                string input = stack.Pop();
                if (input == "+")
                {
                    sum += int.Parse(stack.Pop());
                }
                else if (input == "-")
                {
                    sum -= int.Parse(stack.Pop());
                }
                if (stack.Count == 0)
                {
                    break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
