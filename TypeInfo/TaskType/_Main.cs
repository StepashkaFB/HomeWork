using System.Reflection;

namespace TaskType
{
    class _Main
    {
        static void Main(string[] args)
        {
            TypeInfo Information = typeof(TempInfo).GetTypeInfo();
            TypeInformation.ShowProperty(Information);
            TypeInformation.ShowFileds(Information);
            TypeInformation.ShowMethods(Information);
            TypeInformation.ShowConstructors(Information);
        }
    }
}
