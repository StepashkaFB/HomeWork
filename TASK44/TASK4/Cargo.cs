using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK4
{
    class Cargo : IAnimalInZoo, IColor
    {
        public string Name { get; set; }
        public bool Fly { get; set; }
        public bool Walk { get; set; }
        public string Color { get; set; }
    }
}
