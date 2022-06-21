using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            int indexHalfLength = inputs.Length / 2;

            string firstHalfString = inputs.Substring(0, indexHalfLength);
            string secondHalfString = inputs.Substring(indexHalfLength);

            foreach (var input in firstHalfString)
            {
                stack.Push(input);
            }

            foreach (var input in secondHalfString)
            {
                queue.Enqueue(input);
            }

            bool isBalanced = true;

            for (int i = 0; i < firstHalfString.Length; i++)
            {
                char stackChar = stack.Pop();
                char queueChar = queue.Dequeue();
                if (!(stackChar == '[' || stackChar == '{' || stackChar == '(' || stackChar == ' '))
                {
                    continue;
                }
                if (!(stackChar == 40 || stackChar == 91 || stackChar == 123 || stackChar == 32))
                {
                    isBalanced = false;
                    break;
                }
                if ((stackChar == queueChar - 2) || (stackChar == queueChar - 1) || (stackChar == queueChar))
                {
                    continue;
                }
                else
                {
                    isBalanced = false;
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Balanced_Parenthesis
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var parentesis = Console.ReadLine().ToCharArray();
//            bool isBalanced = true;
//            Stack<char> stack = new Stack<char>();

//            foreach (var item in parentesis)
//            {
//                if (item == '{' || item == '[' || item == '(')
//                {
//                    stack.Push(item);
//                    continue;
//                }

//                if (stack.Count == 0)
//                {
//                    isBalanced = false;
//                    break;
//                }

//                if (item == '}' && stack.Peek() == '{')
//                {
//                    stack.Pop();
//                }
//                else if (item == ']' && stack.Peek() == '[')
//                {
//                    stack.Pop();
//                }
//                else if (item == ')' && stack.Peek() == '(')
//                {
//                    stack.Pop();
//                }
//                else
//                {
//                    isBalanced = false;
//                    break;
//                }
//            }

//            if (!isBalanced || stack.Count > 0)
//            {
//                Console.WriteLine("NO");
//            }
//            else
//            {
//                Console.WriteLine("YES");
//            }
//        }
//    }
//}
