using System;
using System.IO;

namespace MyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\Laptop\samples\TITpe21";
            string filePath = directoryPath + @"\MyFiles.txt";
            string[] fileData = File.ReadAllLines(filePath);

            for (int i = 0; i < fileData.Length; i++)
            {
                fileData[i] = fileData[i].Replace('4', 'a');
                fileData[i] = fileData[i].Replace('0', 'o');
                fileData[i] = fileData[i].Replace('1', 'i');
                fileData[i] = fileData[i].Replace('3', 'e');
            }
            for (int i = 0; i < fileData.Length; i++)
            {
                File.Create($@"{directoryPath}\{fileData[i]}.txt");
            }


        }
    }
}
