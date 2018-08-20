using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaskExseptions
{
    class ListOfWorker
    {
        static List<Worker> ListWorker = new List<Worker>();
        
        public static void AddNewWorker(Worker OurWorker)
        {
            if(OurWorker.Age < 18)
            {
                throw new InvalidWorker("Persons under 18 are not allowed to register", OurWorker.Identify);
            }
            if(OurWorker.Identify < 1)
            {
                throw new InvalidWorker("Incorrect ID", OurWorker.Identify);
            }
            Regex regex = new Regex("^[a-zA-Z]+$");
            if (!regex.IsMatch(OurWorker.FirstName))
            {
                throw new InvalidWorker("Incorrect first name", OurWorker.Identify);
            }
            if (!regex.IsMatch(OurWorker.LastName))
            {
                throw new InvalidWorker("Incorrect last name", OurWorker.Identify);
            }
            ListWorker.Add(OurWorker);
        }
        public static void ShowList()
        {
            foreach(var temp in ListWorker)
            {
                Console.WriteLine("Full name: {0} {1}", temp.FirstName, temp.LastName);
                Console.WriteLine("Age: {0}", temp.Age);
                Console.WriteLine("Identify: {0}", temp.Identify);
            }
        }
    }
}
