using System;

namespace lesson16
{
    class MyClass
    {
        private static int counter = 0;
        private int odId;
        public MyClass()
        {
            odId = counter++;
            Console.WriteLine($"Created: {odId}");
        }
        ~MyClass()
        {
            Console.WriteLine($"Destruct: {odId}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region
            MyClass value;
            for (int i = 0; i < 1000; i++)
            {
                value = new MyClass();
                //GC.Collect(0);
                //GC.Collect(1);   //Поколения [0 - 2]
                //GC.Collect(2);
            }

            #endregion
        }
    }
}
