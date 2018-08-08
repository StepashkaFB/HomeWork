using System;
using System.Collections.Generic;
using System.Linq;

namespace TASK4
{
    class Queries
    {
        // Fly = true 
        public static void SelectedByFlyTrue(List<IAnimalInZoo> ListOfAnimals)
        {
            var selectedFlyTrue = from tempData in ListOfAnimals
                                  where tempData.Fly == true
                                  select tempData;

            Console.WriteLine("Selected by Fly = true");
            foreach (var temp in selectedFlyTrue)
            {
                Console.WriteLine("Name : {0} -- Color : {1} -- Fly : {2} -- Walk : {3}",
                    temp.Name, temp.Color, temp.Fly, temp.Walk);
            }
            Console.WriteLine();
        }
        // Fly = false
        public static void SelectedByFlyFalse(List<IAnimalInZoo> ListOfAnimals)
        {
            var selectedFlyFalse = ListOfAnimals.Where(animal => animal.Fly == false);

            Console.WriteLine("Selected by Fly = false");
            foreach (var temp in selectedFlyFalse)
            {
                Console.WriteLine("Name : {0} -- Color : {1} -- Fly : {2} -- Walk : {3}",
                    temp.Name, temp.Color, temp.Fly, temp.Walk);
            }
            Console.WriteLine();
        }
        //Sort by Name, start with S
        public static void SortByName(List<IAnimalInZoo> ListOfAnimals)
        {
            var SortName = from tempData in ListOfAnimals
                           where tempData.Name.ToUpper().StartsWith("S")
                           orderby tempData.Name
                           select tempData;

            Console.WriteLine("Sorted by Name, starts with S");
            foreach(var temp in SortName)
            {
                Console.WriteLine("Name : {0} -- Color : {1} -- Fly : {2} -- Walk : {3}",
                    temp.Name, temp.Color, temp.Fly, temp.Walk);
            }
            Console.WriteLine();
        }
        //Creating New type with Name and Color only
        public static void SelectNewObject(List<IAnimalInZoo> ListOfAnimals)
        {
            var AnotherObj = from tempData in ListOfAnimals
                             let Name = "Animal: " + tempData.Name
                             let Color = "White - " + tempData.Color
                             select new
                             {
                                 FullName = Name,
                                 NewColor = Color
                             };
            foreach(var temp in AnotherObj)
            {
                Console.WriteLine("Name : {0} -- Color : {1}", temp.FullName, temp.NewColor);
            }
            Console.WriteLine();
        } 
        public static void TakeColorWhite(List<IAnimalInZoo> ListOfAnimals)
        {
            foreach(var temp in ListOfAnimals.TakeWhile(tempData => tempData.Color.StartsWith("White")))
            {
                Console.WriteLine("Name : {0} -- Color : {1} -- Fly : {2} -- Walk : {3}",
                    temp.Name, temp.Color, temp.Fly, temp.Walk);
            }
        }
    }
}
