using System;
using System.Reflection;

namespace HelloApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom("MyApp.exe");

            Console.WriteLine(asm.FullName);
            // получаем все типы из сборки MyApp.dll
            Type[] types = asm.GetTypes();
            foreach (Type t in types)
            {
                Console.WriteLine(t.Name);
            }
            Console.ReadLine();
        }
    }
}
