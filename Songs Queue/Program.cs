using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();

            Queue<string> queueSongs = new Queue<string>();

            foreach (string s in songs)
            {
                queueSongs.Enqueue(s);
            }

            while (queueSongs.Count != 0)
            {
                string command = Console.ReadLine();

                int indexOfSpace = command.IndexOf(' ');
                if (indexOfSpace != -1)
                {
                    string action = command.Substring(0, indexOfSpace);
                    string song = command.Substring(indexOfSpace + 1);

                    if (queueSongs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                        continue;
                    }
                    queueSongs.Enqueue(song);
                }
                else
                {
                    if (command == "Play")
                    {
                        queueSongs.Dequeue();
                        continue;
                    }
                    Console.WriteLine(string.Join(", ", queueSongs.ToArray()));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
