using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
           


            Car[] arr = new Car[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = new Car();
                arr[i].Drive();
                arr[i].NewMethodFromCar2();
            }







        }
    }
}
