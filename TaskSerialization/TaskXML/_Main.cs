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
            book_1.SaveToXml(path, book_1);
            book_1.ShowXML(path);

            Book book_2 = new Book("","",0);
            //Load From XML
            book_2.LoadFromXML(path, ref book_2);
            Console.WriteLine(book_2.ShowFullBook());

            string path1 = @"D:\папка\TaskXML\TaskXML\BookJson.json";
            //Save to JSON file
            book_2.SaveToJson(path1, ref book_2);
            Book book_3 = new Book("", "", 0);

            //Load From JSON File
            book_3.LoadFromJSON(path1, ref book_3);
            Console.WriteLine(book_3.ShowFullBook());

            //Binary
            string path2 = @"D:\папка\TaskXML\TaskXML\BinaryData.bin";
            Book NameBook = new Book("GoodName", "GoodAuthor", 50);
            NameBook.SaveToBinary(path2, ref NameBook);

            Book book_4 = new Book("", "", 0);
            book_4.LoadFromBinary(path2, ref book_4);
            Console.WriteLine(book_4.ShowFullBook());

            //DataSer
            string path3 = @"D:\папка\TaskXML\TaskXML\DataSer.xml";
            Book SimpleBook = new Book("WithOutName", "WithOutAuthor", 500);
            SimpleBook.SaveToDataSerialization(path3, ref SimpleBook);

            Book book_5 = new Book("", "", 0);
            book_5.LoadFromDataSerialization(path3, ref book_5);
            Console.WriteLine(book_5.ShowFullBook());
        }
    }
}

