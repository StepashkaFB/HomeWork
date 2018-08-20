using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvents
{
    class Herbivore
    {
        public event EventHandler<string> onGrowth = delegate { };
        public string Name { get; set; }
        public Herbivore(string Name)
        {
            this.Name = Name;
        }
        public void Message(object sender, string temp)
        {
            Console.WriteLine("The herbivore ate the plant");
            onGrowth?.Invoke(this, Name);
        }
    }
}
