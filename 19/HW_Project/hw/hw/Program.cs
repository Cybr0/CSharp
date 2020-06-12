using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 1) Console
            Console.WriteLine("hw1:");
            Type type = typeof(Console);
            Console.WriteLine(type);
            for (int i = 0; i < type.GetMethods().Length; i++)
            {
                var meth = type.GetMethods()[i];
                Console.WriteLine($"Метод {i}:");
                Console.WriteLine($"Имя метода: {meth.Name}");
                Console.WriteLine($"Сигнатура: {meth.ToString()}");
                Console.WriteLine(new string('-',50) + "\n");
            }

            /* 
            //можно так
            foreach (var item in type.GetMethods())
            {

            } 
            */
            #endregion

            #region 2)
            Console.WriteLine("\n\nhw2:\n" + new string('#',50) + "\n");
            User user = new User("Tim",27);
            Type userType = user.GetType();


            int itr = 1;
            foreach (var userMeth in userType.GetProperties())
            {
                Console.WriteLine($"{itr}) Имя медода: {userMeth.ToString()}");
                Console.WriteLine($"Возвращаемое значение: {userMeth.GetValue(user)}");
                Console.WriteLine(new string('-',50) + "\n");
                itr++;
            }
            #endregion

        }
    }
}
