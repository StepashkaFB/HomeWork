using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Product
    {
        string Name;
        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }
        int Amount;
        public int _Amount
        {
            get { return Amount; }
            set { Amount = value; }
        }
        int Price;
        public int _Price
        {
            get { return Price; }
            set { Price = value; }
        }

        public Product(string Name, int Amount,int Price)
        {
            this.Name = Name;
            this.Amount = Amount;
            this.Price = Price;
        }
    }
}
