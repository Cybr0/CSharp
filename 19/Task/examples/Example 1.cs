using System;
using System.Reflection;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(User);
            // получение типа с помощью метода GetType класса Object
            User user = new User("Tom", 30);
            myType = user.GetType();
            // третий способ получения типа - статический метод Type.GetType()
            myType = Type.GetType("TestConsole.User", false, true);
            // еще один способ когда после полного имени класса через запятую указывается имя сборки
            myType = Type.GetType("TestConsole.User, MyLibrary", false, true);

            Console.WriteLine(myType.ToString());
            Console.ReadKey();
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
