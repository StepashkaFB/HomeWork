using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Serialization;

namespace TaskXML
{
    [DataContract][Serializable]
    public class Book
    {
        [DataMember][XmlAttribute]
        string FullName;
        
        public string _FullName
        {
            get { return FullName; }
            set { FullName = value; }
        }
        [DataMember][XmlAttribute]
        string Author;
        
        public string _Author
        {
            get { return Author; }
            set { Author = value; }
        }
        [DataMember][XmlAttribute]
        int AmountPage;
        
        public int _AmountPage
        {
            get { return AmountPage; }
            set { AmountPage = value; }
        }
        public Book() { }
        public Book(string FullName, string Author, int AmountPage)
        {
            this.FullName = FullName;
            this.Author = Author;
            this.AmountPage = AmountPage;
        }

        //XML serialization
        public void SaveToXml(string path, Book tempbook)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Book));
            using (StreamWriter strW = new StreamWriter(path))
            {
                serializer.Serialize(strW, tempbook);
            }
        }
        public string ShowFullBook()
        {
            return "FullName: " + FullName + "--" +
                " Author: " + Author + "--" +
                " Page: " + AmountPage;
        }
        public void LoadFromXML(string path, ref Book tepmbook)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Book));
            using (StreamReader streader = new StreamReader(path))
            {
                tepmbook = (Book)serializer.Deserialize(streader);
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
        //JSON serialization
        public void SaveToJson(string path, ref Book tempBook)
        {
            
            using (FileStream filest = new FileStream(path, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Book));
                jsonFormatter.WriteObject(filest, tempBook);
            }
        }
        public void LoadFromJSON(string path, ref Book tempBook)
        {
            using (FileStream filest = new FileStream(path, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Book));
                tempBook = (Book)jsonFormatter.ReadObject(filest);
            }
        }
        //Using binary serialization
        public void SaveToBinary(string path, ref Book tempbook)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                formatter.Serialize(stream, tempbook);
            }
        }
        public void LoadFromBinary(string path, ref Book tempbook)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(path, FileMode.Open))
            {
                tempbook = (Book)formatter.Deserialize(stream);
            }
        }
        //Using the DataContractSerializer
        public void SaveToDataSerialization(string path, ref Book tempbook)
        {
            using (FileStream filest = new FileStream(path, FileMode.OpenOrCreate))
            {
                DataContractSerializer DataSer = new DataContractSerializer(typeof(Book));
                DataSer.WriteObject(filest, tempbook);
            }
        }
        public void LoadFromDataSerialization(string path, ref Book tempbook)
        {
            using (FileStream filest = new FileStream(path, FileMode.OpenOrCreate))
            {
                DataContractSerializer DataSer = new DataContractSerializer(typeof(Book));
                tempbook = (Book)DataSer.ReadObject(filest);
            }
        }
    }
}
