using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите диапазон массива.\n" +
                "Нижний диапазон: ");
            int downSize = int.Parse(Console.ReadLine());
            Console.Write("Верхний диапазон: ");
            int upSize = int.Parse(Console.ReadLine());
            Console.WriteLine();

            RangeOfArray arr = new RangeOfArray(downSize, upSize);
            Random random = new Random();
            
            for (int i = downSize; i <= upSize; i++)
            {
                arr[i] = random.Next(10);
                Console.WriteLine($"arr[{i}]  =  {arr[i]}");
            }
        }
    }
}
