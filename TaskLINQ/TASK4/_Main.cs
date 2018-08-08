using System.Collections.Generic;

namespace TASK4
{
    class _Main
    {
        static void Main(string[] args)
        {
            List<IAnimalInZoo> ListOfAnimals = new List<IAnimalInZoo>
            {
                 new Feline() { Name = "SimpleCat", Color = "White", Fly = false, Walk = true },
                 new Feline() { Name = "SuperCat", Color = "White", Fly = true, Walk = true },
                 new Bird() { Name = "Chiken", Color = "Red", Fly = true, Walk = true },
                 new Predator() { Name = "Lion", Color = "Black", Fly = false, Walk = true },
                 new Bird() {Name = "Parrot", Color = "Green", Fly = true, Walk = true}
            };

            Queries.SelectedByFlyTrue(ListOfAnimals);
            Queries.SelectedByFlyFalse(ListOfAnimals);
            Queries.SortByName(ListOfAnimals);
            Queries.SelectNewObject(ListOfAnimals);
            Queries.TakeColorWhite(ListOfAnimals);
        }
    }  
}
//{Name = "", Color = "", Fly = , Walk = }