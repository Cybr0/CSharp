using System;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Программа которая выйдет за пределы массива.\n" +
                "Введите размер массива: ");
            int SIZE = int.Parse(Console.ReadLine());
            int[] arr = new int[SIZE];

            try
            {
                for (int i = 0; i < arr.Length + 1; i++)
                {
                    arr[i] = i + 1;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("\nЗавершение обработки массива");
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
