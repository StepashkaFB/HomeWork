using System;

namespace StringTransform
{
    class _Main
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an amount of strings:  ");
            int Amount = int.Parse(Console.ReadLine());
            TextTransformer transform = new TextTransformer(Amount);

            Console.WriteLine("Filling strings:");
            for (int Counter = 0; Counter < Amount; Counter++)//input
            {
                transform.tempstring[Counter] = Console.ReadLine();
            }

            foreach(string Name in transform)//output
            {
                Console.WriteLine(Name);
            }
        }
    }  
}
