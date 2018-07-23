using System.Collections.Generic;

namespace TASK4
{
    public interface IGroup<out T> where T : IAnimalInZoo
    {
        IReadOnlyCollection<T> Animals { get; }
    }
}
