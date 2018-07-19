using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class _Main
    {
        static void Main(string[] args)
        {
            List<Product> AllProducts = new List<Product>();
            List<Product> TempProduct = new List<Product>();

            Shopclass ShopMain = new Shopclass("Pyaterochka", AllProducts);
            Console.Write("Enter your name: ");
            string NAME = Console.ReadLine();
            Console.Write("Enter the amount of money: ");
            int MONEY = int.Parse(Console.ReadLine());
            Customer customer1 = new Customer(NAME, MONEY);
            Order order = new Order();

            bool Continue = true;
            Console.WriteLine("Select the following actions:");
            Console.WriteLine("1 - Show List of Product");
            Console.WriteLine("2 - Add new pruduct in your own Basket");
            Console.WriteLine("3 - Show your own Basket");
            Console.WriteLine("4 - Show your Money");
            Console.WriteLine("5 - Clear your Basket");
            Console.WriteLine("6 - Comit an order");
            Console.WriteLine("7 - Initialization");//Uses by Admin
            Console.WriteLine("8 - Add new Product");//Uses by Admin
            while (Continue)
            {
                int choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1://Show all available Product
                        ShopMain.ShowAllProducts();
                        break;
                    case 2://Add products in Basket 
                        try
                        {
                            Console.WriteLine();
                            ShopMain.ShowAllProducts();
                            Console.WriteLine("Enter the product number:");
                            int number = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the product quantity:");
                            int quantity = int.Parse(Console.ReadLine());
                            order.AddToBasket(ShopMain, customer1, number, quantity);
                        }
                        catch(ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 3:
                        customer1.ShowBasket();
                        break;
                    case 4:// Show balance
                        Console.WriteLine(customer1._Money);
                        break;
                    case 5:
                        order.ClearBasket(customer1, AllProducts);
                        ShopMain.Sh(ref TempProduct);
                        break;
                    case 6:
                        Console.WriteLine("Purchase Information:");
                        Console.WriteLine("Name of Shop: {0}", ShopMain._NameShop);
                        Console.WriteLine("Your name: {0}", customer1._FullName);
                        Console.WriteLine("Your products:");
                        customer1.ShowBasket();
                        Console.WriteLine("Money left: {0}", customer1._Money);
                        customer1._StartMoney = customer1._Money;
                        break;
                    case 7:
                        ShopMain.AddNewProduct("Banan", 15, 75, ref TempProduct);
                        ShopMain.AddNewProduct("Apple", 30, 90, ref TempProduct);
                        ShopMain.AddNewProduct("Grape", 25, 100, ref TempProduct);
                        break;
                    case 8:
                        Console.WriteLine();
                        Console.Write("Enter the product name:");
                        string name=Console.ReadLine();
                        Console.Write("Enter an amount of product:");
                        int amount = int.Parse(Console.ReadLine());
                        Console.Write("Enter a price of product:");
                        int price = int.Parse(Console.ReadLine());
                        ShopMain.AddNewProduct(name,amount,price, ref TempProduct);
                        Console.WriteLine();
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
