using System;

namespace HomeWork1
{
    class _Main
    {
		static void DemonOfUsingVarious(Student S1, ref Mark[] mark)
		{
			Console.WriteLine();
			bool Continue = true;
			Console.WriteLine("Select the following actions:");
			Console.WriteLine("1 - Show Average of Marks");
			Console.WriteLine("2 - Show lvl of Marks");
			Console.WriteLine("3 - Reset all Marks");
			Console.WriteLine("4 - Show inf about Marks");
			Console.WriteLine("5 - Sort Marks");
			while (Continue)
			{
				int choise = int.Parse(Console.ReadLine());
				switch (choise)
				{
					case 1:
						Console.WriteLine("AvgMark = {0:0.##}", S1.GetAvgMark());
						break;
					case 2:
						double AverageMark = S1.GetAvgMark();
						S1.InfLvlMark(AverageMark, out string Result);
						Console.WriteLine(Result);
						break;
					case 3:
						S1.ResetAllMarks();
						break;
					case 4:
						Console.WriteLine();
						S1.ShowInfAboutMark();
						break;
					case 5:
						Console.WriteLine();
						S1.SortMarks(ref mark);
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
			DemonOfUsingVarious(S1, ref Marks1);
		}
	}
}
