using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class RangeOfArray
    {
        public RangeOfArray(int downIndex, int upIndex)
        {
            if (downIndex >= upIndex)
            {
                throw new ArgumentOutOfRangeException("Некоректное значение заданных параметров.");
            }
            down = downIndex;
            up = upIndex;
            size = up - down + 1;
            arr = new int[size];
        }

        private  int down;
        private  int up;
        private int size;
        private int[] arr;

        public int Length { get { return size; } }
        public int this[int i] 
        { 
            set 
            { 
                if(i >= down && i<= up)
                {
                    arr[(i - down)] = value * value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Некоректное значение индекса.");
                }
            }

            get
            {
                if (i >= down && i <= up)
                {
                    return arr[(i - down)];
                }
              
                throw new ArgumentOutOfRangeException("Некоректное значение индекса.");
               
            }
        }
    }
}
