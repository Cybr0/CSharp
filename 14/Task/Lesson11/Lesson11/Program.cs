using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    enum Vacancy:int
    {
        v_admin,
        v_worker,
        v_accounter
    }
    interface MyInterface
    {
        void newMessage();
        int getCount();
    }
    struct MyStruct:MyInterface
    {
        public MyStruct(string m)
        {
            msg = m;
        }
        private string msg;
        public string message()
        {
            return "Hello";
        }
        public void newMessage()
        {
            Console.WriteLine("New message");
        }
        public int getCount()
        {
            return 42;
        }

    }
    class Program
    {
        public static bool fileExists()
        {
            return false;
        }
        public static bool fileValue()
        {
            return true;
        }
        public static bool? getval()
        {
            if (fileExists())//file absent
            {
                return fileValue();
            }
            else
            {
                return null;
            }
        }

        public static double? getTemp()
        {
            return null;
        }
        static void Main(string[] args)
        {
            Vacancy v_val = Vacancy.v_admin;
            Console.WriteLine($"type:{v_val} val:{(int)v_val}");
            Console.WriteLine(v_val.ToString());

            string str = null;
            int? a = null;
            bool? b = getval();
            System.Nullable<bool> bb = true;
            if(b != null)
            {
                if ((bool)b)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("NULL");
            }

            bool def = getval()??true;

        }
    }
}
