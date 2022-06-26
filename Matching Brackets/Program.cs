using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();
            int indexOfOpenBracket = 0;
            int indexOfCloseBracket = 0;
            Stack<int> stack = new Stack<int>();


            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == '(')
                {
                    stack.Push(i);
                }
                else if (inputs[i] == ')')
                {
                    indexOfOpenBracket = stack.Pop();
                    indexOfCloseBracket = i;
                    string findedBrackets = inputs.Substring(indexOfOpenBracket, indexOfCloseBracket - indexOfOpenBracket + 1);
                    Console.WriteLine(findedBrackets);
                }
            }

        }
    }
}
