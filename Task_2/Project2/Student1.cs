using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
	class Student
	{
		string FirstName;
		string MiddleName;
		string LastName;
		int Amount;
		public Mark[] Marks1 = new Mark[0];// Array of Marks

		public Student(string FirstName, string MiddleName, string LastName, int Amount)
		{
			this.FirstName = FirstName;
			this.MiddleName = MiddleName;
			this.LastName = LastName;
			this.Amount = Amount;
		}
		public void EnterMarks(Mark[] mark)
		{
			Marks1 = mark;
		}
		public double GetAvgMark()
		{
			double AvgMark = 0;
			try
			{
				for (int Counter = 0; Counter < Amount; Counter++)
				{
					AvgMark += Marks1[Counter]._ValueOfMark;
				}
				AvgMark /= Amount;
				Console.WriteLine();
			}
			catch (DivideByZeroException ex) 
			{
				Console.WriteLine(ex.Message);
			}
			return AvgMark;
		}
		public void ResetAllMarks()
		{
			for (int Counter = 0; Counter < Amount; Counter++)
			{
				Marks1[Counter]._ValueOfMark = 0;
			}
		}
		//using various 
		//types of statements and parameters.
		public void InfLvlMark(double AvgMark, out string Resalt)
		{
			//Information about the level of assessment
			Resalt = "";
			if (AvgMark < 4)
				Resalt = "Bad";
			else if (AvgMark >= 4 && AvgMark <= 7)
				Resalt = "Normally";
			else
				Resalt = "Excellent";
		}
		public void ShowInfAboutMark()
		{
			Console.WriteLine("Fullname: {0}  {1}  {2}", FirstName, MiddleName, LastName);
			for (int Counter = 0; Counter < Marks1.Length; Counter++)
			{
				Console.WriteLine("Name of Mark :\t{0}", Marks1[Counter]._NameOfSubject);
				Console.WriteLine("Value of Mark:\t{0}", Marks1[Counter]._ValueOfMark);
				Console.WriteLine();
			}
			Console.WriteLine();
		}
		public void SortMarks(ref Mark[] mark)
		{
			try
			{
				for (int CounterF = 0; CounterF < mark.Length; CounterF++)
				{
					for (int CounterS = mark.Length - 1; CounterS > CounterF; CounterS--)
					{
						if (mark[CounterS - 1]._ValueOfMark > mark[CounterS]._ValueOfMark)
						{
							object temp = mark[CounterS - 1];
							mark[CounterS - 1] = mark[CounterS];
							mark[CounterS] = (Mark)temp;
						}
					}
				}
			}
			catch(IndexOutOfRangeException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

