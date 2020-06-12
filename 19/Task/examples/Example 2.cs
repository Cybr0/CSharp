using System;
using System.Reflection;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = Type.GetType("HelloApp.User", false, true);

            // получаем информацию о методах
            Console.WriteLine("Методы:");
            foreach (MethodInfo method in myType.GetMethods())
            {
                string modificator = "";
                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual";
                Console.Write($"{modificator} {method.ReturnType.Name} {method.Name} (");
                // получаем все параметры
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
            // получаем информацию о конструкторах
            Console.WriteLine("Конструкторы:");
            foreach (ConstructorInfo ctor in myType.GetConstructors())
            {
                Console.Write(myType.Name + " (");
                // получаем параметры конструктора
                ParameterInfo[] parameters = ctor.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }
            // получаем информацию о полях и свойствах
            Console.WriteLine("Поля:");
            foreach (FieldInfo field in myType.GetFields())
            {
                Console.WriteLine($"{field.FieldType} {field.Name}");
            }

            Console.WriteLine("Свойства:");
            foreach (PropertyInfo prop in myType.GetProperties())
            {
                Console.WriteLine($"{prop.PropertyType} {prop.Name}");
            }
            // ищем все реализованные интерфейсы
            Console.WriteLine("Реализованные интерфейсы:");
            foreach (Type i in myType.GetInterfaces())
            {
                Console.WriteLine(i.Name);
            }

            foreach (MemberInfo mi in myType.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }
            Console.ReadLine();
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public void Display()
        {
            Console.WriteLine($"Имя: {Name}  Возраст: {Age}");
        }
        public int Payment(int hours, int perhour)
        {
            return hours * perhour;
        }
    }
}
