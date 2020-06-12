using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 6-ти значный номер билета: ");
            int[] arr = new int [6];
            int checkLuckyTiket = 0;
            try
            {
                string enteredNumber = Console.ReadLine();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(Convert.ToString(enteredNumber[i]));
                    if (i < 3) checkLuckyTiket += arr[i];
                    else checkLuckyTiket -= arr[i];
                }
                /*
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
                */
                if (checkLuckyTiket == 0) Console.WriteLine("\nМои поздравления, у тебя счастливый билет!\n");
                else Console.WriteLine("\nВ следующий раз повезет.\n");

            }
            catch (Exception)
            {
                Console.WriteLine("Введены некорректные даннные!");
            }
           
        }
    }
}
