using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите размер массива M: ");
                int[] arrM = new int [int.Parse(Console.ReadLine())];
                Console.Write("\nВведите размер массива N: ");
                int[] arrN = new int[int.Parse(Console.ReadLine())];

                int size = arrM.Length + arrN.Length;
                int[] tmpArr = new int[size]; // временный массив

                Random random = new Random();


                Console.Clear();
                Console.Write("\n arr1 = ");
                for (int i = 0; i < arrM.Length; i++)
                {
                    arrM[i] = random.Next(10);
                    Console.Write(arrM[i] + "\t");
                    tmpArr[i] = arrM[i];
                }

                Console.Write("\n arr2 = ");
                for (int i = 0, j = arrM.Length; i < arrN.Length; i++, j++)
                {
                    arrN[i] = random.Next(10);
                    Console.Write(arrN[i] + "\t");
                    tmpArr[j] = arrN[i];
                }

                Console.Write("\n arr3 = ");
                IEnumerable<int> MN = tmpArr.Distinct();
                foreach (var item in MN)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine("\n\n");
            }

            catch (Exception)
            {

                Console.WriteLine("Ошибка ввода данных!");
            }
           
        }
    }
}
