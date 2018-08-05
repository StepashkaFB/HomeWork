using System;
using System.Collections.Generic;
using System.IO;

namespace ListFile
{
    class _Main
    {
        static void ShowFiles(List<string> FileStorage) // show list of files
        {
            int temp = 0;
            foreach (var File in FileStorage)
            {
                Console.WriteLine("Number of file -- {0} -- Name: {1}", temp++, File);
            }
        }
        static void ReadSelectedFile(List<string> FileStorage, int number)//read contents of file.
        {
            StreamReader streader = new StreamReader(FileStorage[number]);
            Console.WriteLine(streader.ReadToEnd());
            streader.Close();
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a path, like --  D:\\Qwerty");
                string path = Console.ReadLine();
                List<string> FileStorage = new List<string>(Directory.GetFiles(path));//list all files in directory

                ShowFiles(FileStorage);

                Console.Write("Enter a number of file you want to read: ");
                int number = int.Parse(Console.ReadLine());
                ReadSelectedFile(FileStorage, number);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
