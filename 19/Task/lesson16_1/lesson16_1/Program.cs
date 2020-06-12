using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace lesson16_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(User);

            Console.WriteLine(myType);

            User usr = new User("John Doe", 33);
            Type myType2 = usr.GetType();

            MethodInfo [] mets = myType.GetMethods();
            foreach (MethodInfo item in mets)
            {
                Console.WriteLine(item.ToString());
                if(item.Name == "Payment2")
                {
                    Console.WriteLine(item.Invoke(null, new object[]{2,5}));
                }
            }
            foreach (ConstructorInfo item in myType.GetConstructors())
            {
                Console.WriteLine(item.ToString());
            }
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

        public static int Payment2(int hours, int perhour)
        {
            return hours * perhour;
        }

    }
}

