using System;
using System.Linq;

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
        //performing math statistics operations
        public static double RangeOfVariation(double[] Set)
        {
            var min = Set.Min();
            var max = Set.Max();
            return max - min;
        }
        public static double ExpectedValue( double[] Set)
        {
            double sum = 0;
            for (int Counter = 0; Counter < Set.Length; Counter++)
            {
                sum += Set[Counter];
            }  
            return sum/Set.Length;
        }
        public static double MeanDeviation(double[] Set)
        {
            double sum = 0;
            double ExpValue = ExpectedValue(Set);
            for (int Counter = 0; Counter < Set.Length; Counter++)
            {
                sum += Math.Abs((Set[Counter] - ExpValue));
            }
            sum /= Set.Length;
            return sum;
        }
        public static double Dispersion(double[] Set)
        {
            double sum = 0;
            double ExpValue = ExpectedValue(Set);
            for (int Counter = 0; Counter < Set.Length; Counter++)
            {
                sum += Math.Pow(Set[Counter] - ExpValue, 2);
            }
            sum /= Set.Length;
            return sum;
        }
        public static double StandardDeviation(double[] Set)
        { 
            return Math.Sqrt(Dispersion(Set));
        }
    }
}

