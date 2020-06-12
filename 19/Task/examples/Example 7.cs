using System;
using System.Reflection;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User tom = new User("Tom", 35);
            User bob = new User("Bob", 16);
            bool tomIsValid = ValidateUser(tom);
            bool bobIsValid = ValidateUser(bob);

            Console.WriteLine($"Реультат валидации Тома: {tomIsValid}");
            Console.WriteLine($"Реультат валидации Боба: {bobIsValid}");
            Console.ReadLine();
        }
        static bool ValidateUser(User user)
        {
            Type t = typeof(User);
            object[] attrs = t.GetCustomAttributes(false);
            foreach (AgeValidationAttribute attr in attrs)
            {
                if (user.Age >= attr.Age) return true;
                else return false;
            }
            return true;
        }
    }

    [AgeValidation(18)]
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string n, int a)
        {
            Name = n;
            Age = a;
        }
    }
}
