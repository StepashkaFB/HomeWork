using System;
using System.Linq;

namespace TaskGCD
{
    class GettingGCD
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
        public static int SecondAlg(int first, int second, int third)
        {
            int GCD = Math.Min(first, Math.Min(second, third));
            for (; GCD > 1; GCD--)
            {
                if (first % GCD == 0 && second % GCD == 0 && third % GCD == 0)
                    break;
            }
            return GCD;
        }
        public static int ThirdAlg(int value1, int value2)
        {
            int TempF = 1;
            int TempS = value1 < value2 ? value1 : value2;
            int TempT = 0;
            int OurGCD = value1 < value2 ? value2 : value1;
            do
            {
                while (OurGCD - (TempF * TempS) >= TempS)
                {
                    TempF++;
                }
                TempT = OurGCD - (TempF * TempS);
                OurGCD = TempS;
                TempS = TempT;
            }
            while (TempT > 0);
            return OurGCD;
        }
    }
}