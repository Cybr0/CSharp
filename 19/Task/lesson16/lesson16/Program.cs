using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson16
{
    class MyClass
    {
        private static int counter = 0;
        private int obId;
        public MyClass()
        {
            obId = counter++;
            Console.WriteLine($"Created:{obId}");
        }
        ~MyClass()
        {
            Console.WriteLine($"Destruct:{obId}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass value;
            for (int i = 0; i < 1000; i++)
            {
                value = new MyClass();
                GC.Collect(2);
            }
        }
    }
}
