using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson24
{
    
    class MyAction
    {
        public delegate void showMessage();
        public event showMessage actionEvent;
        public void doAction()
        {
            if(myDelegate != null)
            {
                myDelegate();
            }
            if(actionEvent != null)
            {
                actionEvent();
            }
        }
        private showMessage myDelegate;
        public void add(showMessage item)
        {
            if(myDelegate == null)
            {
                myDelegate = item;
            }
            else
            {
                myDelegate += item;
            }
        }

        public void remove(showMessage item)
        {
            myDelegate -= item;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyAction act = new MyAction();

            //act.add(new MyAction.showMessage(helloStr));
            //act.add(new MyAction.showMessage(actionStr));
            //act.add(new MyAction.showMessage(byeStr));

            act.actionEvent += new MyAction.showMessage(helloStr);
            act.actionEvent += new MyAction.showMessage(actionStr);
            act.actionEvent += byeStr;

            //foreach (var inv in act.actionEvent)
            //{
            //    Console.WriteLine(inv.Method.ToString());
            //}
            act.doAction();


        }
        static public void helloStr()
        {
            Console.WriteLine("Hello world!");
        }
        static public void actionStr()
        {
            Console.WriteLine("Do something");
        }
        static public void byeStr()
        {
            Console.WriteLine("Good bye!");
        }
    }
}
