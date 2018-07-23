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
            Group<Bird> BirdGroup = new Group<Bird>();

            Bird Duck = new Bird() { Name = "Duck",Color = "Black", Fly = true, Walk = true };
            Bird Chiken = new Bird() { Name = "Chiken", Color = "Red", Fly = false, Walk = true };
            Bird Parrot = new Bird() { Name = "Parrot", Color = "Green", Fly = true, Walk = true };
            //Addition to the group of animals
            BirdGroup.GroupAnimal(Duck);
            BirdGroup.GroupAnimal(Chiken);
            BirdGroup.GroupAnimal(Parrot);
            
            Group<Predator> PredatorGroup = new Group<Predator>();
            Group<Cargo> CargoGroup = new Group<Cargo>();
            Group<Feline> FelineGroup = new Group<Feline>();
            Group<Primate> PrimateGroup = new Group<Primate>();

            //The list which contains animals of various kinds
            MainZoo GeneralGroup = new MainZoo();
            GeneralGroup.zoo = new List<IGroup<IAnimalInZoo>>();

            GeneralGroup.zoo.Add(BirdGroup);
            GeneralGroup.zoo.Add(PredatorGroup);
            GeneralGroup.zoo.Add(CargoGroup);
            GeneralGroup.zoo.Add(FelineGroup);
            GeneralGroup.zoo.Add(PrimateGroup);
        }
    }  
}
