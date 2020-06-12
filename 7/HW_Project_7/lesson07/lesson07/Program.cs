using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            Curency myCurency = new Curency("USD");
            Console.WriteLine(myCurency.ToString());
            myCurency.Value = 123;
            Console.WriteLine(myCurency.ToString());

            Curency newCur = new Curency("RUB");
            newCur.Value = 20;
            try
            {
                Curency result = myCurency + newCur;
                Console.WriteLine(result.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(newCur++);
            Console.WriteLine(++newCur);

            var tmp = newCur + 22.3;
            Console.WriteLine(tmp);

            double d = newCur;
            Console.WriteLine(d);
            newCur = (Curency)4.5;

            Computer tmpC = new Computer();
            tmpC.power_on = false;
            if (tmpC)
            {
                Console.WriteLine("power is on");
            }
            else
            {
                Console.WriteLine("power is off");
            }
        }
    }
}
