using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4
{
    class Program
    {
        static bool mainMenuOrGone()
        {
            Console.WriteLine("a) на главный экран");
            Console.WriteLine("b) выход");
            Console.Write("Выберите пункт: ");
            string menu = Console.ReadLine();
            if (menu == "a")
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("hw4.");


            string password = "123";
            int balance = 10000000;
            int itr = 0;
            while(itr < 3)
            {
                Console.Write("Введите пароль: ");
                string checkPassword = Console.ReadLine();
                if (checkPassword == password)
                    break;
                else
                    Console.WriteLine("Не верный пароль.");
                if(itr == 2)
                {
                    Console.WriteLine("Вы исчерпали количество попыток.");
                    return;
                }
                itr++;
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("a) вывод баланса на экран");
                Console.WriteLine("b) пополнение счёта");
                Console.WriteLine("c) снять деньги со счёта");
                Console.WriteLine("d) выход");
                Console.Write("Выберите пункт, введя 'a,b,c или d': ");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "a":
                        Console.Clear();
                        Console.WriteLine("Ваш баланс: Очень много денег.");
                        if (mainMenuOrGone())
                            return;
                        else
                            break;
                        

                    case "b":
                        Console.Clear();
                        Console.WriteLine("Введите сумму для пополнения: ");
                        int sum = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ваш баланс: Очень много денег + " + sum);
                        balance += sum;
                        if (mainMenuOrGone())
                            return;
                        else
                            break;
                    case "c":
                        Console.Clear();
                        Console.WriteLine("Введите сумму для cнятия: ");
                        sum = int.Parse(Console.ReadLine());
                        if(sum < balance)
                        {
                            Console.WriteLine("Ваш баланс: Очень много денег - " + sum);
                            balance -= sum;
                        }
                        else
                        {
                            Console.WriteLine("не получилось снять деньги, у Вас столько нет!");
                            Console.ReadKey();
                            break;
                        }
                    
                        if (mainMenuOrGone())
                            return;
                        else
                            break;
                    default:
                        return;
                }
            }
            
        }
    }
}
