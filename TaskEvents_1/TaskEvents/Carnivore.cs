using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvents
{
    class Carnivore
    {
        public event EventHandler<string> onGrowth = delegate { };
        public string Name { get; set; }
        public Carnivore(string Name)
        {
            this.Name = Name;
        }
        public void Message(object sender, string temp)
        {
            Console.WriteLine("The carnivore ate the herbivore");
            onGrowth?.Invoke(this, Name);
        }
    }
}
