using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w_object = new Worker();
            try
            {
                w_object["name"] = "John Doe";
                w_object["salary"] = "100,54";
                w_object["position"] = "CEO";

                w_object[0] = "John Doe";
                w_object[2] = "100,54";
                w_object[1] = "CEO";

                Console.WriteLine(w_object);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
