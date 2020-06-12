using System;
using System.Reflection;

namespace HelloApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assembly asm = Assembly.LoadFrom("MyApp.exe");

                Type t = asm.GetType("MyApp.Program", true, true);

                // создаем экземпляр класса Program
                object obj = Activator.CreateInstance(t);

                // получаем метод GetResult
                MethodInfo method = t.GetMethod("GetResult");

                // вызываем метод, передаем ему значения для параметров и получаем результат
                object result = method.Invoke(obj, new object[] { 6, 100, 3 });
                Console.WriteLine((result));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}