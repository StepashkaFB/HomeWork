using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class _Main
	{
		static void AddNewEmpl(ref List<Employee> lstEmpl)//Creat new Employee
		{
			Console.Write("Enter Full Name:  ");
			string Fullname = Console.ReadLine();
			Console.Write("Enter the salary:  ");
			int Salary = int.Parse(Console.ReadLine());
			lstEmpl.Add(new Employee(Fullname, Salary));
		}
		static void BeforeSort(ref List<Employee> lstEmpl)//Show full List
		{
			Console.WriteLine("Before sort:");
			foreach (Employee empl in lstEmpl)//Before sort
			{
				Console.WriteLine("Worker: {0} -- {1}", empl._FullName, empl._Salary);
			}
		}
		static void ResultOfSortByPersonalInfo(ref List<Employee> lstEmpl)//Sort by Person
		{
			lstEmpl.Sort(lstEmpl[0]);
			Console.WriteLine();
			Console.WriteLine("After sort:");
			foreach (Employee empl in lstEmpl)//After sort
			{
				Console.WriteLine("Worker: {0} -- {1}", empl._FullName, empl._Salary);
			}
		}
		static void ResultOfSortBySalary(ref List<Employee> lstEmpl)//Sort by Salary
		{
			lstEmpl.Sort(Employee.SortBySalary);
			Console.WriteLine();
			Console.WriteLine("After sort:");
			foreach (Employee empl in lstEmpl)//After sort
			{
				Console.WriteLine("Worker: {0} -- {1}", empl._FullName, empl._Salary);
			}
		}
		static void Main(string[] args)
		{
			List<Employee> lstEmpl = new List<Employee>();//initialization
			lstEmpl.Add(new Employee("Stepan HH GG", 2900));
			lstEmpl.Add(new Employee("Ivan JJ LL", 4040));
			lstEmpl.Add(new Employee("Alex II OO", 3500));
			lstEmpl.Add(new Employee("Dominik PP YY", 7340));
			lstEmpl.Add(new Employee("Anton FF UU", 5688));
			lstEmpl.Add(new Employee("Valantin WW EE", 5566));
			lstEmpl.Add(new Employee("Vlad DD FF", 7745));

			Console.WriteLine();
			bool Continue = true;
			Console.WriteLine("Select the following actions:");
			Console.WriteLine("1 - Show List");
			Console.WriteLine("2 - Sort by PersonInf and Show List");
			Console.WriteLine("3 - Sort by Salary and Show List");
			Console.WriteLine("4 - Add new Employee");
			while (Continue)
			{
				int choise = int.Parse(Console.ReadLine());
				switch (choise)
				{
					case 1:
						BeforeSort(ref lstEmpl);
						break;
					case 2:
						ResultOfSortByPersonalInfo(ref lstEmpl);
						break;
					case 3:
						ResultOfSortBySalary(ref lstEmpl);
						break;
					case 4:
						AddNewEmpl(ref lstEmpl); 
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
