using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson14
{
    interface IObjectInfo
    {
        string getInfo();
    }
    struct Car: IObjectInfo
    {
        public string getInfo()
        {
            return $"model:{model}\n";
        }
        public string model;
    }
    class User:IObjectInfo
    {
        public User() { }
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string getInfo()
        {
            return $"Name:{name}\nAge:{age}\n";
        }
        public string name;
        public int age;
    }
    class Animal:IObjectInfo
    {
        public Animal(string name, int age, string type)
        {
            this.name = name;
            this.age = age;
            this.type = type;
        }
        public string getInfo()
        {
            return $"Name:{name}\nAge:{age}\nType:{type}\n";
        }
        public string name;
        public string type;
        public int age;
    }
    class ShowInfo<T> where T: IObjectInfo 
    {
        private T obj;
        public static int stat_member;
        public ShowInfo()
        {
            this.obj = default(T);
            //this.obj = obj;
        }
        public ShowInfo(T obj)
        {
            this.obj = obj;
        }
        public void Show()
        {
            Console.WriteLine(obj.getInfo());
            Console.WriteLine($"stat member  {stat_member}");
            Console.WriteLine();
        }
    }

    class ShowInfoClass
    {
        public void Show<T>(T obj) where T: IObjectInfo
        {
            Console.WriteLine(obj.getInfo());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShowInfo<User>.stat_member = 4;
            ShowInfo<Animal>.stat_member = 5;
            ShowInfo<Car>.stat_member = 6;

            ShowInfo<User> uss = 
                new ShowInfo<User>(new User("John", 42));
            uss.Show();
            ShowInfo<User> uss1 =
                new ShowInfo<User>(new User("Jane", 32));
            uss1.Show();

            ShowInfo<Animal> ann = 
                new ShowInfo<Animal>(new Animal("Reks", 6, "Dog"));
            ann.Show();
            ShowInfo<Car> cc =
                new ShowInfo<Car>(new Car());
            cc.Show();

            ShowInfoClass sic = new ShowInfoClass();
            sic.Show(new User("Some name", 44));

            Dictionary<int, string> myDict = new Dictionary<int, string>();

            myDict.Add(0, "zero");
            myDict.Add(1, "one");
            myDict.Add(2, "two");
            myDict[2] = myDict[2] + 1;

            Console.WriteLine($"key exists:{myDict.ContainsKey(3)}");
            Console.WriteLine($"value exists:{myDict.ContainsValue("one")}");
            foreach(var item in myDict)
            {
                Console.WriteLine($"k:{item.Key}, v:{item.Value}");
            }
            Console.WriteLine($"-----HashSet-----------");
            HashSet<int> hs_int = new HashSet<int>();
            hs_int.Add(5);
            hs_int.Add(2);
            hs_int.Add(3);
            hs_int.Add(2);
            hs_int.Add(2);
            hs_int.Add(3);
            hs_int.Add(4);
            hs_int.Add(5);
            hs_int.Add(5);
            foreach (var item in hs_int)
            {
                Console.WriteLine($"k:{item}");
            }
        }
    }
}
