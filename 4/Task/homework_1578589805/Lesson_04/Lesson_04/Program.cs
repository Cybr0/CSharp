using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker ww = new Worker();
            ww.setName();
            Console.WriteLine(ww.Name);
            ww.Name = "Jane Doe";
            ww.Salary = 150;

            Worker dd = new Worker();
            dd.Name = "John Doe";
            dd.Salary = 100;

            Console.WriteLine(ww.Name);
            Console.WriteLine(dd.Name);
            dd = ww;
            dd.Name = "New Name";
            dd.Position = "accounter";
            Console.WriteLine(ww.Name);
            Console.WriteLine(dd.Name);
            Console.WriteLine(dd.Position);

            double the_value1;
            double the_value2 = 10;
            if (dd.read_from_file(out the_value1, out the_value2))
            {
                Console.WriteLine(the_value1);
            }
            else
            {
                Console.WriteLine("read error");
            }
            int i_val = 0;
            dd.get_val(ref i_val);

            dd = null;
            if (dd != null)
            {
                Console.WriteLine(ww.Name);
                Console.WriteLine(dd.Name);
            }

            
        }
    }
}
