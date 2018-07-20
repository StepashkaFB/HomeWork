using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Customer
    { 
        string FullName;
        public string _FullName
        {
            get { return FullName; }
        }
        int Money;
        int StartMoney;
        public int _StartMoney
        {
            get { return StartMoney; }
            set { StartMoney = value; }
        }
        public int _Money
        {
            get { return Money; }
            set { Money = value; }
        }
        public Customer(string FullName, int Money)
        {
            this.FullName = FullName;
            this.Money = Money;
            StartMoney = Money;
        }      
    }
}
