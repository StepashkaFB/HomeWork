using System.Collections.Generic;

namespace TASK4
{
    public class Group<T> where T : IAnimalInZoo
    {
        private readonly List<T> animals = new List<T>();
        public IReadOnlyCollection<T> Animals
        {
            get { return animals.AsReadOnly();}
        }
        public void GroupAnimal(T animal)
        {
            animals.Add(animal);
        }
    }
}
