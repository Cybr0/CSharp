using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08
{
    class Worker
    {
        private string name;
        private string position;
        private double salary;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string Position
        {
            set { position = value; }
            get { return position; }
        }
        public double Salary
        {
            set { salary = value; }
            get { return salary; }
        }

        public string this[string str]
        {
            get {
                string ret_val = null;
                switch (str)
                {
                    case "name":
                        ret_val = name;
                        break;
                    case "position":
                        ret_val = position;
                        break;
                    case "salary":
                        ret_val = salary.ToString();
                        break;
                    default:
                        break;
                }
                return ret_val;
            }
            set {
                switch (str)
                {
                    case "name":
                        name = value;
                        break;
                    case "position":
                        position = value;
                        break;
                    case "salary":
                        salary = double.Parse(value);//CultureInfo.InvariantCulture
                        break;
                    default:
                        break;
                }
            }
        }
        public string this[int i]
        {
            get {
                string ret_val = null;
                switch (i)
                {
                    case 0:
                        ret_val = name;
                        break;
                    case 1:
                        ret_val = position;
                        break;
                    case 2:
                        ret_val = salary.ToString();
                        break;
                    default:
                        break;
                }
                return ret_val;
            }
            set {
                switch (i)
                {
                    case 0:
                        name = value;
                        break;
                    case 1:
                        position = value;
                        break;
                    case 2:
                        salary = double.Parse(value);//CultureInfo.InvariantCulture
                        break;
                    default:
                        break;
                }
            }
        }
        public int this[int x, int y]
        {
            get { return 0; }
            set { }
        }
        public override string ToString()
        {
            return $"name:{name}\nsalary:{salary}\nposition:{position}\n";
        }
    }
}
