using System.Threading;

namespace TaskStopWatch
{
    class STOPWATCH
    {
        static bool Control = true;
        static int Counter = 0;

        public static void  CountingTime()
        {
            while(Control)
            {
                Counter++;
                Thread.Sleep(1);
            }
        }
        public static void Start()
        {
            Control = true;
        }
        public static void Stop()
        {
            Control = false;
        }
        public static void Reset()
        {
            Counter = 0;
        }
        public static string Show()
        {
            return Counter.ToString() + "ms";
        }
    }
}