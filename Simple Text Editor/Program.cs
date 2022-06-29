﻿//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace Simple_Text_Editor
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int numberOfCommands = int.Parse(Console.ReadLine());

//            StringBuilder sb = new StringBuilder();

//            Stack<string> stack = new Stack<string>();

//            for (int i = 0; i < numberOfCommands; i++)
//            {
//                string[] commands = Console.ReadLine().Split(' ');

//                string command = commands[0];

//                if (command == "1")
//                {
//                    string someString = commands[1];
//                    sb.Append(someString);
//                    stack.Push(sb.ToString());
//                }
//                else if (command == "2")
//                {
//                    int count = int.Parse(commands[1]);

//                    for (int j = 0; j < count; j++)
//                    {
//                        stack.Pop();
//                    }
//                }
//                else if (true)
//                {
//                    int index = int.Parse(commands[1]);


//                }


//            }



//        }
//    }
//}

using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            StringBuilder inicialText = new StringBuilder();

            Stack<string> stack = new Stack<string>();
            stack.Push(inicialText.ToString());

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] commands = Console.ReadLine().Split(" ");
                int mainComand = int.Parse(commands[0]);
                if (mainComand == 1)
                {
                    string text = commands[1];
                    inicialText.Append(text);
                    stack.Push(inicialText.ToString());

                }
                else if (mainComand == 2)
                {
                    int countToBeRemoved = int.Parse(commands[1]);
                    int startIndex = inicialText.Length - 1 - countToBeRemoved;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    inicialText.Remove(startIndex, countToBeRemoved);
                    stack.Push(inicialText.ToString());
                }
                else if (mainComand == 3)
                {
                    int index = int.Parse(commands[1]) - 1;
                    if (index > inicialText.Length - 1)
                    {
                        index = inicialText.Length - 1;
                    }
                    char result = inicialText.ToString().ElementAt(index);
                    Console.WriteLine(result);
                }
                else
                {
                    stack.Pop();
                    string result = stack.Peek();
                    StringBuilder sb = new StringBuilder();
                    sb.Append(result);
                    inicialText = sb;
                }

            }
        }
    }
}
