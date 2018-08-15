using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace TaskStopWatch
{
    class _Main
    {
        public static int FirstAlg(params int[] temp)
        {
            int min = temp.Min(), OurGCD;
            for (OurGCD = min; OurGCD > 0; OurGCD--)
            {
                bool reminderIsZero = true;
                for (int Counter = 0; Counter < temp.Length; Counter++)
                {
                    reminderIsZero &= temp[Counter] % OurGCD == 0;

                }
                if (reminderIsZero) break;
            }
            return OurGCD;
        }

        static void Main(string[] args)
        {
            int[] TempArray = new int[3];
            Random rand = new Random();
            for (int i = 0; i < TempArray.Length; i++)
            {
                TempArray[i] = rand.Next();
            }
                
            Thread thread_SW = new Thread(new ThreadStart(STOPWATCH.CountingTime));
            thread_SW.IsBackground = true;
            thread_SW.Start();
            Console.WriteLine(FirstAlg(TempArray));
            STOPWATCH.Stop();
            thread_SW.Join();
            Console.WriteLine(STOPWATCH.Show());

            //Checking, Fault is less than 0.01%
            Stopwatch StopW = new Stopwatch();
            StopW.Start();
            FirstAlg(TempArray);
            StopW.Stop();
            Console.WriteLine(FirstAlg(TempArray));
            Console.WriteLine(StopW.ElapsedMilliseconds + "ms");
        }
    }
}
