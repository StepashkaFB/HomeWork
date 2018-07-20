using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Order
    {
        string TypeOfOrder;
        public string _TypeOfOrder
        {
            get { return TypeOfOrder; }
        }
        int NumberOfOrder;
        public int _NumberOfOrder
        {
            get { return NumberOfOrder; }
        }
        public List<Product> BasketOfProducts = new List<Product>();
        public Order(string TypeOfOrder, int NumberOfOrder)
        {
            this.TypeOfOrder = TypeOfOrder;
            this.NumberOfOrder = NumberOfOrder;
        }
        public void ShowBasket()
        {
            int Counter = 1;
            foreach (Product product in BasketOfProducts)//output
            {
                Console.Write(Counter++); Console.Write(" -- ");
                Console.WriteLine("Name: {0}  Amount: {1}  TotalPrice: {2}", product._Name, product._Amount, (product._Price * product._Amount));
            }
            Counter = 1;
        }
    }
}
