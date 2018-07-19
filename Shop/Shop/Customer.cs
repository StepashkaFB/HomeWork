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
        int StartMoney;//uses for money back to initial value
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
        public List<Product> BasketOfProducts = new List<Product>();//Our main Basket

        public Customer(string FullName, int Money)
        {
            this.FullName = FullName;
            this.Money = Money;
            StartMoney = Money;
        }
        public void ShowBasket()//Output of goods in the basket
        {
            foreach(Product product in BasketOfProducts)
            {
                Console.Write(Counter++); Console.Write(" -- ");
                Console.WriteLine("Name: {0}  Amount: {1}  TotalPrice: {2}", product._Name, product._Amount, (product._Price* product._Amount));
            }
            Counter = 1;
        }
    }
}
