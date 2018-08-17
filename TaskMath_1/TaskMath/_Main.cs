using System;

namespace TaskMath
{
    class _Main
    {
        static void Main(string[] args)
        {
            double[] Set = new double[] { };
            bool Continue = true;
            //Text menu
            Console.WriteLine("Select the following actions:");
            Console.WriteLine("1 - Creat a Set");
            Console.WriteLine("2 - Fill the Set");
            Console.WriteLine("3 - Fill the Set (Random)");
            Console.WriteLine("4 - Show the Set");
            Console.WriteLine("5 - Show Expected Value");
            Console.WriteLine("6 - Show Dispersion");
            Console.WriteLine("7 - Show Standard Deviation");
            Console.WriteLine("8 - Show Mean linear deviation");
            Console.WriteLine("9 - Show the range of variation");
            while (Continue)
            {
                int choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.Write("Enter the number of elements: ");
                        int amount = int.Parse(Console.ReadLine());
                        Set = new double[amount];
                        break;
                    case 2:
                        PerformMath.FillingSet(ref Set);
                        break;
                    case 3:
                        PerformMath.FillingSetRandom(ref Set);
                        break;
                    case 4:
                        PerformMath.ShowSet(ref Set);
                        break;
                    case 5:
                        Console.WriteLine(PerformMath.ExpectedValue(Set));
                        break;
                    case 6:
                        Console.WriteLine(PerformMath.Dispersion(Set));
                        break;
                    case 7:
                        Console.WriteLine(PerformMath.StandardDeviation(Set));
                        break;
                    case 8:
                        Console.WriteLine(PerformMath.MeanDeviation(Set));
                        break;
                    case 9:
                        Console.WriteLine(PerformMath.RangeOfVariation(Set));
                        break;
                    default:
                        Console.WriteLine("Incorrect selection");
                        break;
                }
                Console.WriteLine("Continue? Enter y/n");
                string Choise = Console.ReadLine();
                if (Choise == "n")
                    break;
                else
                    Console.WriteLine("Select another actions");
                continue;
            }
        }
    }
}

