using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK4
{
    class _Main
    {
        static void Main(string[] args)
        {
            //Create a group for storage
            Group<IAnimalInZoo> GeneralGroup = new Group<IAnimalInZoo>();


            Bird Chiken = new Bird() { Name = "Chiken", Color = "Red", Fly = false, Walk = true };
            Predator Lion = new Predator() { Name = "Lion", Color = "Black", Fly = false, Walk = true };
            Feline Cat = new Feline() { Name = "SimpleCat", Color = "White", Fly = false, Walk = true };
            //Addition to the group of animals  
            GeneralGroup.GroupAnimal(Chiken);
            GeneralGroup.GroupAnimal(Cat);
            GeneralGroup.GroupAnimal(Lion);
        }
    }  
}
