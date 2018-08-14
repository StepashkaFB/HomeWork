using System;
using System.Diagnostics;

namespace TaskGCD
{
    class _Main
    {
        static void Main(string[] args)
        {
            int[] IntArray = new int[3] {36, 220, 48 };
            int First = 36;
            int Second = 220;
            int Third = 48;

            Stopwatch stopW = new Stopwatch();
            int OurGCD = 0;
            stopW.Start();
            OurGCD = GettingGCD.GCD(IntArray);
            stopW.Stop();
            Console.WriteLine(OurGCD);
            Console.WriteLine(stopW.Elapsed);

            stopW.Reset();
            stopW.Start();
            OurGCD = GettingGCD.FindGCD(First, Second, Third);
            stopW.Stop();
            Console.WriteLine(OurGCD);
            Console.WriteLine(stopW.Elapsed);

            stopW.Reset();
            stopW.Start();
            OurGCD = GettingGCD.GetGCD(GettingGCD.GetGCD(First, Second), Third);
            stopW.Stop();
            Console.WriteLine(OurGCD);
            Console.WriteLine(stopW.Elapsed);
        } 
    }
}
