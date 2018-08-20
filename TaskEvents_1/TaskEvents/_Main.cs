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
            Plant moss = new Plant("Moss");
            Herbivore hare = new Herbivore("Hare");
            Carnivore wolf = new Carnivore("Wolf");

            // Signed for the event
            moss.onGrowth += hare.Message;
            hare.onGrowth += wolf.Message;

            moss.Growth();
        }
    }
}
