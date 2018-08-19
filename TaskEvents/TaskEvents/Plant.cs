using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvents
{
    class Plant
    {
        public delegate void MethodEat();
        public event MethodEat onGrowth;

        public void Growth()
        {
            int EndOfLife = 100;
            for(int BeginOfLife = 0; BeginOfLife < EndOfLife; BeginOfLife++)
            {
                if(BeginOfLife == 50)
                {
                    Console.WriteLine("Ready to eat");
                    if (onGrowth !=null)
                    {
                        onGrowth();
                    }                   
                }
            }
        }
    }
}
