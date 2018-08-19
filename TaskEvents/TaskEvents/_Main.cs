using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEvents
{
    class _Main
    {
        static void Main(string[] args)
        {
            Plant moss = new Plant();
            Herbivore hare = new Herbivore();
            Carnivore wolf = new Carnivore();

            // Signed for the event
            moss.onGrowth += hare.Message;
            moss.onGrowth += wolf.Message;

            moss.Growth();
        }
    }
}
