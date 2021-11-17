using System;
using System.IO;

namespace CreateTITpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\Users\Laptop\samples\TITpe21";
            bool folderexists = Directory.Exists(folderPath);
            if (!folderexists)
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("TITpe21 folder has been created.");
            }
            else
            {
                Console.WriteLine("TITpe21 folder already exists");
            }
        }
    }
}
