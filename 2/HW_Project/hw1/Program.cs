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
            bool check = true;
            int spaceCount = 0;
            Console.WriteLine("Программа считает количество введенных пробелов\n" +
                        "Введите '.' для выхода.\n");
            while (check)
            {
                try
                {
                    var button = Console.ReadKey().KeyChar;
                    if (button == ' ') { spaceCount++; }
                    else if (button == '.')
                    {
                        Console.WriteLine($"\n\nколичество введеных пробелов = {spaceCount}\n");
                        check = false;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Ошибка ввода!");
                }
               
            }
           
        }
    }
}
