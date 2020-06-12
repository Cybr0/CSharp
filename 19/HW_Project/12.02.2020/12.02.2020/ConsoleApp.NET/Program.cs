using System;
using System.Collections.Generic;
using System.Reflection;

namespace lesson16
{
    #region проверка гарбедж коллектора
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
    #endregion

    public class User
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            #region проверка гарбедж коллектора
            //MyClass value;
            //for (int i = 0; i < 1000; i++)
            //{
            //    value = new MyClass();
            //    //GC.Collect(0);
            //    GC.Collect(2);   //Поколения [0 - 2]
            //    //GC.Collect(2);
            //}

            #endregion

            
            String text = "0123456789";
           
            Type myText = typeof(String);

            foreach (var item in myText.GetMethods())
            {

                if (item.Name == "Substring" && item.GetParameters().Length == 2 )
                {
                    //Console.WriteLine(item.GetParameters()[0].Name); ;
                    Console.WriteLine(item.Invoke(text, new object[] { 1, 5 }));
                }
            }


            var myType1 = typeof(List<int>);

            foreach (var item in myType1.GetConstructors())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n-----------------------------------\n");
            var myType2 = typeof(List<>);

            foreach (var item in myType2.GetConstructors())
            {
                Console.WriteLine(item);
            }

        }
    }
}
