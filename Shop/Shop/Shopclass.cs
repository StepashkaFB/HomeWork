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
        public void Sh(ref List<Product> products)
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
    } 
}
