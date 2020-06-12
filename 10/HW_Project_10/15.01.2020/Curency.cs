using System;
using System.Collections.Generic;
using System.Text;

namespace _15._01._2020
{
    class Curency
    {
        public Curency(string t)
        {
            type = t;
        }

        public double Value
        {
            set
            {
                this.value = value;
            }
            get
            {
                return value;
            }
        }
      
         public  string ToString()
        {
            return $"{value} {type}";
        }

        public string Type { get { return type; } set { type = value; } }
        public static Curency operator +(Curency obj1, Curency obj2)
        {
            if (obj1.type != obj2.type)
                throw new Exception("Нельзя складывать разные типы валют");

            Curency item = new Curency(obj1.type);
            item.Value = obj1.value + obj2.value;
            return item;

        }

        public static Curency operator +(Curency obj1, double obj2)
        {
            Curency item = new Curency(obj1.type);
            item.Value = obj1.value + obj2;
            return item;

        }


        public static Curency operator ++(Curency obj)
        {
            //Curency ret = new Curency(obj.type);
            //ret.value = obj.value + 1;
            //return ret;

            obj.value++;
            return obj;
        }

        public static bool operator ==(Curency obj1, Curency obj2)
        {
            if((obj1.value == obj2.value) && (obj1.type == obj2.type))
                return true;
            return false;
        }

        public static bool operator !=(Curency obj1, Curency obj2)
        {
            if ((obj1.value != obj2.value) || (obj1.type != obj2.type))
                return true;
            return false;
        }

        private double value;
        private string type;
    }

    class ConvertCurency
    {
        public void Convert(ref Curency convertFrom, Curency convertTo) 
        {
            
            Convert(ref convertFrom, convertTo.Type);
        }

        public void Convert(ref Curency curency, string convertTo)
        {
            if(curency.Type != convertTo)
            {
                if (curency.Type == "USD")
                {
                    curency.Value *= 955;
                    curency.Type = "UZS";
                }
                else if (curency.Type == "UZS")
                {
                    curency.Value /= 955;
                    curency.Type = "USD";
                }
            }
        }
    }
}
