using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskHuman
{
    class _Main
    {
        static void Main(string[] args)
        {
            Boy NormalBoy = new Boy(180,75, "Ivan SS HH", 19);
            Console.WriteLine(NormalBoy.ShowInfAboutPerson());
            Console.WriteLine("Show your Chromosome: {0}",NormalBoy.ShowChromosome());
            Console.WriteLine(string.Format("Show your IMB: {0:0.00}", NormalBoy.ShowIndexMassBody()));

            Girl NormalGirl = new Girl(150, "FF", 18) { _UseCosmetics = true };
            Console.WriteLine("Your Height in metres: {0}",NormalGirl.ShowHeightInMeters());

        }
    }
}
