using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaskExseptions
{
    class _Main
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Stepan","DD", 19, 1);
            Worker worker2 = new Worker("SF1", "VV", 19, 2);
            Worker worker3 = new Worker("DD", "AA", 10, 3);
            Worker worker4 = new Worker("HH", "GG", 19, 0);
            try
            {
                ListOfWorker.AddNewWorker(worker1); 
            }
            catch(InvalidWorker ex)
            {
                Console.WriteLine(ex.Message + " ID: {0}", ex.IdentifyOfWorker);
            }

            try
            {
                ListOfWorker.AddNewWorker(worker2);
            }
            catch (InvalidWorker ex)
            {
                Console.WriteLine(ex.Message + " ID: {0}", ex.IdentifyOfWorker);
            }

            try
            {
                ListOfWorker.AddNewWorker(worker3);
            }
            catch (InvalidWorker ex)
            {
                Console.WriteLine(ex.Message + " ID: {0}", ex.IdentifyOfWorker);
            }

            try
            {
                ListOfWorker.AddNewWorker(worker4);
            }
            catch (InvalidWorker ex)
            {
                Console.WriteLine(ex.Message + " ID: {0}", ex.IdentifyOfWorker);
            }
            ListOfWorker.ShowList();
        }
    }
}
