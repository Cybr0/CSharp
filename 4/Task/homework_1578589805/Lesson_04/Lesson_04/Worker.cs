using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_04
{
    class Worker
    {
        /*public Worker(string n, double s)
        {
            Name = n;
            Salary = s;
            counter++;
            Console.WriteLine($"Worker(string n, double s):id = {counter}");
        }*/
        public Worker() {
            counter++;
            Console.WriteLine($"Worker():id={counter}");
        }
        static Worker()
        {
            //read from file .....
            counter = 100;
            Console.WriteLine($"static Worker():id={counter}");
        }
        public void setName(string _name = "default lalalala")//подход С++
        {
            this._name = _name;
        }
        public string getName()//подход С++
        {
            return _name;
        }
        public string Name //подход C#
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Salary
        {
            get { return _salary;  }
            set { _salary = value; }
        }

        public string Position { get; set; }//
        private string _name;
        private double _salary;
        public static string some_text;
        public static int counter;

        public bool read_from_file(out double val1, out double val2)
        {
            val1 = 3232;
            val2 = 300;
            return true;
        }
        public bool get_val(ref int v)
        {
            v = 1231;
            return true;
        }
        

    }
}
