using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvents
{
    
    class Plant
    {
        public event EventHandler<string> onGrowth = delegate { };
        public string Name { get; set; }
        public Plant(string Name)
        {
            this.Name = Name;
        }
        public void Growth()
        {
            int EndOfLife = 100;
            for(int BeginOfLife = 0; BeginOfLife < EndOfLife; BeginOfLife++)
            {
                if(BeginOfLife == 50)
                {
                    Console.WriteLine("Ready to eat");
                    onGrowth?.Invoke(this, Name);
                }
            }
        }
    }
}
