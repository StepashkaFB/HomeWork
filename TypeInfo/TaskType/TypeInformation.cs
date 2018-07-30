using System;
using System.Collections.Generic;
using System.Reflection;

namespace TaskType
{
    class TypeInformation
    {
        public static void ShowProperty(TypeInfo Information)
        {
            IEnumerable<PropertyInfo> declaredProperties = Information.DeclaredProperties;
            Console.Write("Property:");//Display info
            foreach (PropertyInfo property in declaredProperties)
            {
                Console.WriteLine("\n" + property.DeclaringType.Name + ": " + property.PropertyType + ": " + property.Name);
            }
            Console.WriteLine();
        }
        public static void ShowFileds(TypeInfo Information)
        {
            IEnumerable<FieldInfo> declaredField = Information.DeclaredFields;
            Console.Write("Fields:");
            foreach (FieldInfo fields in declaredField)
            {
                Console.WriteLine("\n" + fields.DeclaringType.Name + ": " + fields.FieldType + ": " + fields.Name);
            }
            Console.WriteLine();
        }
        public static void ShowMethods(TypeInfo Information)
        {
            IEnumerable<MethodInfo> declaredMethods = Information.DeclaredMethods;
            Console.WriteLine("Methods:");
            foreach (MethodInfo method in declaredMethods)
            {
                string modificator = "";
                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual ";
                Console.Write(modificator + method.ReturnType.Name + " " + method.Name + " (");

                ParameterInfo[] parameters = method.GetParameters();
                for (int Counter = 0; Counter < parameters.Length; Counter++)
                {
                    Console.Write(parameters[Counter].ParameterType.Name + " " + parameters[Counter].Name);
                    if (Counter + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine();
        }
        public static void ShowConstructors(TypeInfo Information)
        {
            IEnumerable<ConstructorInfo> declaredCons = Information.DeclaredConstructors;
            Console.WriteLine("Constructors:");
            foreach (ConstructorInfo constructors in declaredCons)
            {
                Console.Write(constructors.DeclaringType.Name + " (");
                ParameterInfo[] parameters = constructors.GetParameters();
                for (int Counter = 0; Counter < parameters.Length; Counter++)
                {
                    Console.Write(parameters[Counter].ParameterType.Name + " " + parameters[Counter].Name);
                    if (Counter + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
            Console.WriteLine();
        }
    }
}
