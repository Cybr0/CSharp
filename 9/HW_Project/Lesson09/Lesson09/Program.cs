using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson09
{
    abstract class MyBase
    {
        public abstract void Message();
        public virtual void Message2()
        {
            Console.WriteLine("MyBase.Message2");
        }
    }
    class MyClass:MyBase
    {
        public MyClass(int v)
        {
            some_val = v;
            Console.WriteLine("MyClass Constructor");
        }
        public override void Message()
        {
            Console.WriteLine("MyClass.Message");
        }
        public virtual void ShowMessage()
        {
            Console.WriteLine("MyClass.ShowMessage");
        }
        public int some_val;
        public void func()
        {

        }
    }
    sealed class MySecondClass : MyClass
    {
        public MySecondClass(int vv)
            : base(vv)
        {
            Console.WriteLine("MySecondClass Constructor");
        }
        public override void ShowMessage()
        {
            Console.WriteLine("MySecondClass.ShowMessage");
        }
        public void MyMessage()
        {
            Console.WriteLine("MySecondClass.MyMessage");
            some_val = "some string";
            base.some_val = 5;
        }
        public new string some_val;
        public new void func()
        {

        }
    }
    /*class SomeClass : MySecondClass
    {

    }*/
    class Program
    {
        static void Main(string[] args)
        {
            MySecondClass msc = new MySecondClass(5);
            msc.Message();
            msc.Message2();

            MyClass mc = new MySecondClass(5);
            mc.ShowMessage();
        }
    }
}
