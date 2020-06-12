using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A=0, B=0;
            
            try
            {
                Console.Write("Введите число A: ");
                A = int.Parse(Console.ReadLine());
                Console.Write("\nВведите число B: ");
                B = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (A >= B || A < 0 || B < 0) 
                {
                    Console.WriteLine("Введены не корректные данные");
                    return; 
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введены не корректные данные");
            }

            for (int i = A; i <= B; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat(i, i)));

                //or like this
                //for (int j = 0; j < i; j++)
                //{
                //    Console.Write(i);
                //}
                //Console.WriteLine();
            }

        }
    }
}
