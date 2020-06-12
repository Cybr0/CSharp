using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson07
{
    class Curency
    {
        public Curency(string t)
        {
            _type = t;
        }
        public double Value
        {
            set
            {
                _value = value;
            }
        }
        public override string ToString()
        {
            return $"{_value} {_type}";
        }

        public static Curency operator +(Curency ob1, Curency ob2)
        {
            if(ob1._type != ob2._type)
            {
                throw new Exception("Curency type missmatch");
            }
            Curency ret = new Curency(ob1._type);
            ret.Value = ob1._value + ob2._value;
            return ret;
        }
        public static Curency operator +(Curency ob1, double ob2)
        {
            Curency ret = new Curency(ob1._type);
            ret.Value = ob1._value + ob2;
            return ret;
        }
        public static Curency operator ++(Curency ob)
        {
            //Curency ret = new Curency(ob._type);
            //ret._value = ob._value+1;
            //return ret;
            ob._value++;
            return ob;
        }
        public static bool operator ==(Curency ob1, Curency ob2)
        {
            return ((ob1._value == ob2._value) && (ob1._type == ob2._type));
        }
        public static bool operator !=(Curency ob1, Curency ob2)
        {
            return ((ob1._value != ob2._value) || (ob1._type != ob2._type));
        }

        public static implicit operator double(Curency ob)
        {
            return ob._value;
        }
        public static explicit operator Curency(double v)
        {
            if(v < 0)
            {
                throw new Exception("Value is les than zero");
            }
            Curency ret = new Curency("USD");
            ret.Value = v;
            return ret;
        }
        private double _value;
        private string _type;
    }
    
    class Computer
    {
        public bool power_on{ get; set; }
        public static bool operator false(Computer ob)
        {
            //if (ob.power_on)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
            return !ob.power_on;
        }
        public static bool operator true(Computer ob)
        {
            return ob.power_on;
        }
    }
}
