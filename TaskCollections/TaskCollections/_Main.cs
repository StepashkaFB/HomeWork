using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCollections
{
    class _Main
    {
        static void Main(string[] args)
        {
            Crew MainCrew = new Crew(4);

            MainCrew.Add(new Worker("UU II LL", "Flight attendant", 3));
            MainCrew.Add(new Worker("DD SS FF", "Commander", 1));
            MainCrew.Add(new Worker("TT YY CC", "Second Pilot", 2));
            MainCrew.Add(new Worker("UU II LL", "Flight attendant", 3));

            foreach (var temp in MainCrew)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine();

            Array.Sort(MainCrew.ContentsWorker, MainCrew);

            foreach (var temp in MainCrew)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
    

   

