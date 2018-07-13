using System;


namespace HomeWork1
{
    class _Main
    {
        static void Main()
        {
            string FName = "Stepan";
            string MName = "BE";
            string LName = "GG";

            Console.WriteLine("Fullname: {0}  {1}  {2}", FName, MName, LName);
            Console.WriteLine("Enter the number of Marks");
            int Amount = int.Parse(Console.ReadLine());

            Mark[] Marks1 = new Mark[Amount];
            Student S1 = new Student(FName, MName, LName, Amount);

            string Name;
            int Value;
            for (int Counter = 0; Counter < Amount; Counter++) // Initialization array of Marks
            {
                Console.WriteLine("Enter the name of subject namber of {0}", Counter + 1);
                Name = Console.ReadLine();
                Console.WriteLine("Enter the  mark, namber of {0}", Counter + 1);
                Value = int.Parse(Console.ReadLine());
                Marks1[Counter] = new Mark(Name, Value);
            }
            S1.EnterMarks(Marks1);

            //	Demonstration
            Console.WriteLine();
            Console.WriteLine("AvgMark = {0:0.##}", S1.GetAvgMark());
            Console.WriteLine("Reset all marks");
            S1.ResetAllMarks();
            Console.WriteLine("AvgMark = {0:0.##}", S1.GetAvgMark());
            Console.ReadLine();
        }
    }
}
