using System;

namespace TaskMath
{
    class PerformMath
    {
        public static void FillingSet(ref double[] Set)
        {
            for (int Counter = 0; Counter < Set.Length; Counter++)
            {
                Set[Counter] = double.Parse(Console.ReadLine());
            }
        }
        public static void FillingSetRandom(ref double[] Set)
        {
            Random rand = new Random();
            for (int Counter = 0; Counter < Set.Length; Counter++)
            {
                Set[Counter] = rand.NextDouble();
            }
        }
        public static void ShowSet(ref double[] Set)
        {
            for (int Counter = 0; Counter < Set.Length; Counter++)
            {
                Console.Write(Set[Counter] + " ");
            }
            Console.WriteLine();
        }
        public static void ShowSumOfSet(double[] Set)
        {
            double Sum = 0;
            for (int Counter = 0; Counter < Set.Length; Counter++)
            {
                Sum += Set[Counter];
            }
            Console.WriteLine(Sum);
        }
        //Performing math statistics operations
        public static void _Round(double[] Set)
        {
            for(int Counter = 0; Counter< Set.Length;Counter++)
            {
                Console.WriteLine(Math.Round(Set[Counter]));
            }
        }
        public static void _Pow(double[] Set, int Number)
        {
            for (int Counter = 0; Counter < Set.Length; Counter++)
            {
                Console.WriteLine(Math.Pow(Set[Counter], Number));
            }
            
        }
        public static void _Abs(double[] Set)
        {
            for (int Counter = 0; Counter < Set.Length; Counter++)
            {
                Console.WriteLine(Math.Abs(Set[Counter]));
            }
        }
        public static void _Sqrt(double[] Set)
        {
            for (int Counter = 0; Counter < Set.Length; Counter++)
            {
                Console.WriteLine(Math.Sqrt(Set[Counter]));
            }
        }
        public static void _Sin(double[] Set)
        {
            for (int Counter = 0; Counter < Set.Length; Counter++)
            {
                Console.WriteLine(Math.Sin(Set[Counter]));
            }
        }
        public static void _Cos(double[] Set)
        {
            for (int Counter = 0; Counter < Set.Length; Counter++)
            {
                Console.WriteLine(Math.Cos(Set[Counter]));
            }
        }
    }
}
