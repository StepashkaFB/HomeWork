using System;
using System.Collections.Generic;

namespace TaskType
{

    class TempInfo
    {
        List<int> ExampleList = new List<int>();
        static int Amount;
        string FirstName;
        public string _FirstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        string LastName;
        public string _LastName
        {
            get { return LastName; }
            set { LastName = value; }
        }
        public TempInfo() { }
        public TempInfo(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            Amount++;
        }
        public static int ShowAmount()
        {
            return Amount;
        }
        public void AddToList(int number)
        {
            ExampleList.Add(number);
        }
        public void ShowList()
        {
            foreach(var temp in ExampleList)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
