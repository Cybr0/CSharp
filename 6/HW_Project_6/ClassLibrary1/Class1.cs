using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        public Person(string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;
        }
        public string Name { set; get; }
        public int Age { set; get; }
        public string Position { set; get; }


    }

    public static class DLLStaticClass
    {
        public static void PersonInfo(Person p)
        {
            Console.WriteLine($"Name:\t{p.Name}\n" +
                $"Age:\t{p.Age}\n" +
                $"Position:\t{p.Position}");
        }
        
    }
}
