using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml;

namespace TaskXML
{
    [DataContract]
    class Book
    {
        [DataMember]
        string FullName;
        
        public string _FullName
        {
            get { return FullName; }
            set { FullName = value; }
        }
        [DataMember]
        string Author;
        
        public string _Author
        {
            get { return Author; }
            set { Author = value; }
        }
        [DataMember]
        int AmountPage;
        
        public int _AmountPage
        {
            get { return AmountPage; }
            set { AmountPage = value; }
        }
        public Book(string FullName, string Author, int AmountPage)
        {
            this.FullName = FullName;
            this.Author = Author;
            this.AmountPage = AmountPage;
        }
        public void SaveToXml(string path)
        {
            using (XmlWriter writer = XmlWriter.Create(
                path,
                new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement(ToString());
                writer.WriteStartElement("Informatoin_about_book");
                writer.WriteAttributeString("FullName",FullName);
                writer.WriteAttributeString("Author",Author);
                writer.WriteStartElement("BookDetails");
                writer.WriteElementString("Number_of_page",AmountPage.ToString());
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Flush();  
            }  
        }
        public string ShowFullBook()
        {
            return "FullName: " + FullName + "--" +
                " Author: " + Author + "--" +
                " Page: " + AmountPage;
        }
        public void LoadFromXML(string path)
        {
            using (XmlReader xmlReader = XmlReader.Create(path,
                new XmlReaderSettings() { IgnoreWhitespace = true }))
            {
                xmlReader.MoveToContent();
                xmlReader.ReadStartElement(ToString());
                FullName = xmlReader.GetAttribute("FullName");
                Author = xmlReader.GetAttribute("Author");
                xmlReader.ReadStartElement("Informatoin_about_book");
                xmlReader.ReadStartElement("BookDetails");
                AmountPage = int.Parse(xmlReader.ReadString());
            }
        }
        //Show XML File
        public void ShowXML(string path)
        {
            using (StreamReader streader = new StreamReader(path))
            {
                Console.WriteLine(streader.ReadToEnd());
                streader.Close();
            }
        }
        public void SaveToJson(string path, ref Book tempBook)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Book));
            using (FileStream filest = new FileStream(path, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(filest, tempBook);
            }
        }
        public void LoadFromJSON(string path, ref Book tempBook)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Book));
            using (FileStream filest = new FileStream(path, FileMode.OpenOrCreate))
            {
                tempBook = (Book)jsonFormatter.ReadObject(filest);
            }
        }
    }
}
