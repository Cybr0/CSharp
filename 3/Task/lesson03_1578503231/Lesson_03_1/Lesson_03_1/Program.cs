using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5]; //1

            int[] arr2 = { 1, 2, 3, 4, 5 };//2

            var arr3 = new int[5];//3
            var arr4 = Enumerable.Range(3, 5).ToArray();//4
            
            Console.WriteLine("Lenght:{0}\nMax:{1}\nMin:{2}\nSum:{3}",
                arr2.Length,
                arr2.Max(),
                arr2.Min(),
                arr2.Sum());

            foreach (var item in arr4)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            
            int[,] mat1 = new int[2, 3];
            int[,] mat2 = { {1,2}, { 3, 4 } };
            
            var mat3 = new int[2,2]{ { 1, 2 }, { 3, 4 } };
            int[,,] mat4 = new int[2, 3, 4];

            Console.WriteLine("Lenght:{0}\nRank:{1}",
                mat4.Length,
                mat4.Rank);

            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                {
                    Console.Write("{0} ", mat1[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(new String('-', 20));

            int[][] massiv = new int[3][];
            massiv[0] = new int[3];
            massiv[1] = new int[4];
            massiv[2] = new int[2];
            for (int i = 0; i < massiv.Length; i++)
            {
                for (int j = 0; j < massiv[i].Length; j++)
                {
                    Console.Write("{0} ", massiv[i][j]);
                }
                Console.WriteLine();
            }

            Random rr = new Random();

            Console.WriteLine(rr.Next(0, 100));
            Console.WriteLine(rr.Next(0, 100));
            Console.WriteLine(rr.Next(0, 100));
            Console.WriteLine(rr.Next(0, 100));

            List<int> arrl = new List<int>();
            arrl.Add(0);
            arrl.Add(1);
            arrl.Add(2);
        }
    }
}
