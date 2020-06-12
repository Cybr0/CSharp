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
            double[] A = new double[5];
            double[,] B = new double[3, 4];
            double allSum = 0;
            double commonProduct = 1;
            double evenSumA = 0;
            double oddColSumB = 0;


            Console.WriteLine("Заполните массив A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"\nвведите значение {i} элемента :");
                A[i] = double.Parse(Console.ReadLine());
            }
            Random random = new Random();
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = random.Next(10);
                }
            }


            double maxA = A[0];
            double minA = A[0];

            double minB = B[0, 0];
            double maxB = B[0, 0];
            Console.Clear();
            Console.Write("\n\nArray A: ");
            for (int i = 0; i < A.Length; i++)
            {
                if (maxA < A[i]){  maxA = A[i]; }
                if (minA > A[i]){  minA = A[i]; }
                allSum += A[i];
                commonProduct *= A[i];
                if (i % 2 == 0 && i != 0)
                    evenSumA += A[i];

                Console.Write(A[i] + "\t");
            }



            Console.WriteLine("\n---------------------------------------------------------");



            Console.WriteLine("Array B:\n");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (maxB < B[i,j]) { maxB = B[i, j]; }
                    if (minB > B[i, j]) { minB = B[i, j]; }
                    allSum += B[i, j];
                    commonProduct *= B[i, j];
                    if (j % 2 != 0 && j != 0)
                        oddColSumB += B[i, j];

                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------------------\n");
            if(maxA > maxB)
                Console.WriteLine("max = " + maxA);
            else
                Console.WriteLine("max = " + maxB);

            if (minA < minB)
                Console.WriteLine("min = " + minA);
            else
                Console.WriteLine("min = " + minB);
            Console.WriteLine("sum = " + allSum);
            Console.WriteLine("commonProduct = " + commonProduct);
            Console.WriteLine("sum of even of A = " + evenSumA);
            Console.WriteLine("sum of the odd collumns of B = " + oddColSumB);
        }
    }
}
