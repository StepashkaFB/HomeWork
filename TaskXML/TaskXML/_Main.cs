using System;

namespace TaskXML
{
    class _Main
    {
        static void Main(string[] args)
        {
            //Demonstration Save to XML file
            Book book_1 = new Book("Name!", "Author11", 35);
            string path = @"D:\папка\TaskXML\TaskXML\XMLFile11.xml";
            book_1.SaveToXml(path);
            book_1.ShowXML(path);

            Book book_2 = new Book("","",0);
            //Load From XML
            book_2.LoadFromXML(path);
            Console.WriteLine(book_2.ShowFullBook());

            string path1 = @"D:\папка\TaskXML\TaskXML\BookJson.json";
            //Save to JSON file
            book_2.SaveToJson(path1, ref book_2);
            Book book_3 = new Book("", "", 0);

            //Load From JSON File
            book_3.LoadFromJSON(path1, ref book_3);
            Console.WriteLine(book_3.ShowFullBook());
        }
    }
}

