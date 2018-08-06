using System;
using System.Collections.Generic;
using System.IO;

namespace ListFile
{
    class _Main
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a path, like --  D:\\Qwerty");
                string path = Console.ReadLine();
                //list all files in directory
                List<string> FileStorage = new List<string>(Directory.GetFiles(path));

                WorkWithFile.ShowFiles(FileStorage);

                Console.Write("Enter a number of file you want to read: ");
                int number = int.Parse(Console.ReadLine());
                WorkWithFile.ReadSelectedFile(FileStorage, number);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
