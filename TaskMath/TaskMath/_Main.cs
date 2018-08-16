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
            Console.WriteLine("5 - Show sum of the Set");
            Console.WriteLine("6 - Show Absolut of the Set");
            Console.WriteLine("7 - Show exponentiation");
            Console.WriteLine("8 - Show rounded Set");
            Console.WriteLine("9 - Show sqrt of the set");
            Console.WriteLine("10 - Show sin of the Set");
            Console.WriteLine("11 - Show cos of the Set");
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
                        PerformMath.ShowSumOfSet(Set);
                        break;
                    case 6:
                        PerformMath._Abs(Set);
                        break;
                    case 7:
                        Console.Write("Enter the power of number: ");
                        int value = int.Parse(Console.ReadLine());
                        PerformMath._Pow(Set, value);
                        break;
                    case 8:
                        PerformMath._Round(Set);
                        break;
                    case 9:
                        PerformMath._Sqrt(Set);
                        break;
                    case 10:
                        PerformMath._Sin(Set);
                        break;
                    case 11:
                        PerformMath._Cos(Set);
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

