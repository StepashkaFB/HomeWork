using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Shopclass
    {
        string NameShop;
        public string _NameShop
        {
            get { return NameShop; }
        }
        public List<Product> AllProducts = new List<Product>();
       
        public Shopclass(string Name, List<Product> products)
        {
            NameShop = Name;
            AllProducts = products;
        }
        public void RecovoryList(ref List<Product> products)
        {
            AllProducts = products;
        }
        public void ShowAllProducts()
        {
            int Counter = 1;
            foreach (Product product in AllProducts)
            {
                Console.Write(Counter++); Console.Write(" -- ");
                Console.WriteLine("Name: {0},  Amount: {1},  Price:  {2}.", product._Name, product._Amount, product._Price);
            }
            Counter = 1;
        }
        public void AddNewProduct(string name, int amount, int price, ref List<Product> TempL)//Adding new product
        {
            AllProducts.Add(new Product(name, amount, price));
            TempL.Add(new Product(name, amount, price));
        }
        public void AddToBasket(Customer customer, Order order, int number, int quantity)//Client Basket
        {
            int temp = AllProducts[number - 1]._Amount;
            if ((temp -= quantity) < 0)//Check for availability
            {
                Console.WriteLine("Not enough goods in a shop");
                temp = 0;
            }
            else if ((customer._Money - (AllProducts[number - 1]._Price) * quantity) < 0)
            {
                Console.WriteLine("Not enough money");
            }
            else
            {
                order.BasketOfProducts.Add(new Product(AllProducts[number - 1]._Name, quantity, AllProducts[number - 1]._Price));
                AllProducts[number - 1]._Amount -= quantity;// Change Amount in a shop
                customer._Money -= (AllProducts[number - 1]._Price * quantity);//Change money
                order.ShowBasket();
            }
        }
        public void ClearBasket(Customer customer, Order order, List<Product> products)
        {
            order.BasketOfProducts.Clear();
            products.Clear();
            customer._Money = customer._StartMoney;
        }
    } 
}
