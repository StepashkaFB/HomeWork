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
                Console.WriteLine();
            }
			catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero");
                throw;
            }	
		    return AvgMark / Amount; 
		}
		public void ResetAllMarks()
		{
			for (int Counter = 0; Counter < Amount; Counter++)
			{
				Marks1[Counter]._ValueOfMark = 0;
			}
		}           
    }
}	 
