using System;

namespace lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int tmp;
            int firstSum = 0;
            int secondSum = 0;
            while (true)
            {
                string number = Console.ReadLine();
                if (number.Length != 6)
                {
                    Console.WriteLine("Длина введенного числа должна равнятся 6");
                    continue;
                }
                if (!int.TryParse(number, out tmp))
                {
                    Console.WriteLine("Требуется вводить цифры");
                    continue;
                }
                int size = number.Length / 2;
                for (int i = 0; i < size; i++)
                {
                    arr[i] = int.Parse(Char.ToString(number[i]));
                    firstSum += arr[i];

                    arr[i + size] = int.Parse(Char.ToString(number[i + size]));
                    secondSum += arr[i + size];
                }
                if (firstSum == secondSum)
                {
                    Console.WriteLine("LUCK");
                }
                else
                {
                    Console.WriteLine("NOT");
                }
                return;
            }
        }
    }
}
