using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Введите число: ");
			try
			{
				string reString = Console.ReadLine();
				if (int.Parse(reString) < 0)
				{ 
					Console.WriteLine("Число должно быть положительным.");
					return;
				}
				char[] arr = reString.ToCharArray();
				Array.Reverse(arr);
				Console.WriteLine(arr);
			}
			catch (Exception)
			{
				Console.WriteLine("Введены некорректные данные!");
			}
        }
    }
}
