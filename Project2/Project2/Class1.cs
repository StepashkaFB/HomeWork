using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
	class Mark
	{
      string NameOfSubject;
	  int ValueOfMark;
		public int _ValueOfMark
		{
			get { return ValueOfMark; }
			set { ValueOfMark = value; }
		}
		public Mark(string NameOfSubject, int ValueOfMark)
		{
			this.NameOfSubject = NameOfSubject;
			this.ValueOfMark = ValueOfMark;
		}
	}
	class Student
	{
		string FirstName;
		string MiddleName;
		string LastName;
		
		int Amount;
		Mark[] Marks1 = new Mark[3];// Array of Marks
		Student(string FirstName, string MiddleName, string LastName, int i)
		{
			this.FirstName = FirstName;
			this.MiddleName = MiddleName;
			this.LastName = LastName;
			this.Amount = i;
			
		}
		public object EnterMarks()
		{
			string Name;
			int Value;
			Mark[] Marks = new Mark[Amount];
			Console.WriteLine("Fullname {0} {1} {2}", FirstName, MiddleName, LastName);
			for (int i = 0; i< Amount; i++) // Initialization array of Marks
			{
				Console.WriteLine("Enter the name of subject namber of {0}", i+1);
				Name = Console.ReadLine();
				Console.WriteLine("Enter the  mark, namber of {0}", i+1);
				Value = int.Parse(Console.ReadLine());
				Marks[i] = new Mark(Name, Value);
			}
			return Marks1 = Marks;
		}
		public double GetAvgMark()
		{
			double AvgMark = 0;
			try {
				for (int i = 0; i < Amount; i++)
				{
					AvgMark += Marks1[i]._ValueOfMark;
				}
				AvgMark /= Amount;
			}
			catch { DivideByZeroException e; }		
			return AvgMark / Amount; 
		}
		public void ResetAllMarks()
		{
			for (int i = 0; i < Amount; i++)
			{
				Marks1[i]._ValueOfMark = 0;
			}
		}
		static void Main()
		{
			int Amount = 3;
			Student S1 = new Student("Stepan", "BE", "GG", Amount);
			S1.EnterMarks();
			//	Demonstration
			Console.WriteLine();
			Console.WriteLine("AvgMark = {0:0.##}", S1.GetAvgMark());
			Console.WriteLine("Reset all marks");
			S1.ResetAllMarks();
			Console.WriteLine("AvgMark = {0:0.##}", S1.GetAvgMark());
		}
	}
}