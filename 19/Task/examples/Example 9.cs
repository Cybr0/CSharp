using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadLine();
        }

        static void Test()
        {
            using (User u = new User { Name = "Tom" })
            {
                // переменная u доступна только в блоке using
                Console.WriteLine($"Некоторые действия с объектом User. Получим его имя: {u.Name}");
            }
            Console.WriteLine("Конец метода Test");
        }
    }
    public class User : IDisposable
    {
        public string Name { get; set; }
        public void Dispose()
        {
            Console.WriteLine("Объект был уничтожен");
        }
    }
}
