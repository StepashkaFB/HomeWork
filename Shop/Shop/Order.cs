using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Order
    {
        
        public void AddToBasket(Shopclass ShopMain, Customer customer, int number, int quantity)//Client Basket
        {
            int temp = ShopMain.AllProducts[number - 1]._Amount;
            if ((temp -= quantity) < 0)//Check for availability
            {
                Console.WriteLine("Not enough goods in a shop");
                temp = 0;
            }
            else if ((customer._Money - (ShopMain.AllProducts[number - 1]._Price) * quantity) < 0)
            {
                Console.WriteLine("Not enough money");
            }
            else
            {
                customer.BasketOfProducts.Add(new Product(ShopMain.AllProducts[number - 1]._Name, quantity, ShopMain.AllProducts[number - 1]._Price));
                ShopMain.AllProducts[number-1]._Amount -= quantity;// Change Amount in a shop
                customer._Money -= (ShopMain.AllProducts[number-1]._Price * quantity);//Change money
                customer.ShowBasket();
            }
        }
        public void ClearBasket(Customer customer, List<Product> products)
        {
            customer.BasketOfProducts.Clear();
            products.Clear();
            customer._Money = customer._StartMoney;//money back to initial value
        }
    }
}
