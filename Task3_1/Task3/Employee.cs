using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Employee: IComparer<Employee>
	{
		string FullName;
		public string _FullName
		{
			get { return FullName; }
			set { FullName = value; }
		}
		int Salary;
		public int _Salary
		{
			get { return Salary; }
			set { Salary = value; }
		}
		public Employee(string Name, int Salary)
		{
			this.FullName = Name;
			this.Salary = Salary;
		}
		public static int SortBySalary(Employee E1, Employee E2)
		{
			return E1._Salary.CompareTo(E2._Salary);
		}
		public int Compare(Employee E1, Employee E2)
		{
			if (E1._FullName.Length > E2._FullName.Length)
				return 1;
			else if (E1._FullName.Length < E2._FullName.Length)
				return -1;
			return 0;
		}

	}
}

