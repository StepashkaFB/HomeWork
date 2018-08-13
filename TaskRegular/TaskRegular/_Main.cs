using System;

namespace TaskRegular
{
    class _Main
    {
        static void Main(string[] args)
        {
            //True
            Console.WriteLine(RegularExp.EmailAdress("stepan_kill@mail.ru"));
            //False
            Console.WriteLine(RegularExp.EmailAdress("stepan_kill@mailru"));
            //True
            Console.WriteLine(RegularExp.Url("http://www.google.by"));
            Console.WriteLine(RegularExp.URLValid("http://www.google.by"));
            //True
            Console.WriteLine(RegularExp.FilePathValid(@"D:\папка\dd"));
            //False
            Console.WriteLine(RegularExp.FilePathValid(@"D:\папка\:dd"));
        } 
    }
}
