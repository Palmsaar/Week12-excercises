using System;
using System.Collections.Generic;
using System.IO;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            string Directory = @"C:\Users\Laptop\samples";
            string filePath = Directory + @"\ToDoList.txt";

            List<string> Todo = new List<string>();
            bool fileExists = File.Exists(filePath);
            if (fileExists)
            {
                AddToList(Todo);
            }
            else if (!fileExists)
            {
                File.Create(filePath).Close();
                AddToList(Todo);
            }
            File.WriteAllLines(filePath, Todo);

        }
        static void AddToList(List<string> someList)
        {
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine(@"Would you like to add something to the list?(y\n)");
                string userInput = Console.ReadLine();
                if (userInput == "y")
                {
                    Console.WriteLine("Enter your entry!");
                    someList.Add(Console.ReadLine());
                    continue;
                }
                else
                {
                    Console.WriteLine("Have a nice day!");
                    i++;
                }

            }
        }
    }
}
