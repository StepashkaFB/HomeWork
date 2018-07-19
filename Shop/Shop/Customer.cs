using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Customer
    {
        static int Counter = 1;
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
        public List<Product> BasketOfProducts = new List<Product>();

        public Customer(string FullName, int Money)
        {
            this.FullName = FullName;
            this.Money = Money;
            StartMoney = Money;
        }
        public void ShowBasket()
        {
            foreach(Product product in BasketOfProducts)//output
            {
                Console.Write(Counter++); Console.Write(" -- ");
                Console.WriteLine("Name: {0}  Amount: {1}  TotalPrice: {2}", product._Name, product._Amount, (product._Price* product._Amount));
            }
            Counter = 1;
        }
    }
}
