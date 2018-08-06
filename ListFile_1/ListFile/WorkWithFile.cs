using System;
using System.Collections.Generic;
using System.IO;

namespace ListFile
{
    class WorkWithFile
    {
        // show list of files
        public static void ShowFiles(List<string> FileStorage)
        {
            int temp = 0;
            foreach (var File in FileStorage)
            {
                Console.WriteLine("Number of file -- {0} -- Name: {1}", temp++, File);
            }
        }
        //read contents of file
        public static void ReadSelectedFile(List<string> FileStorage, int number)
        {
            StreamReader streader = new StreamReader(FileStorage[number]);
            Console.WriteLine(streader.ReadToEnd());
            streader.Close();
        }
    }
}
