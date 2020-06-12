using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClassLibrary1; //проверка


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person a = null; //проверка
            ////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("----------- hw1 ----------"); // создать класс библиотек и ...
            ClassLibrary1.Person person = new ClassLibrary1.Person("Abu", 18, "Overlord");
            ClassLibrary1.DLLStaticClass.PersonInfo(person);



            ////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n----------- hw2 ----------"); // создать класс с константами и ...
            Console.WriteLine($"Name: {hw2_ConstLiteral.name}\n" +
                $"Age: {hw2_ConstLiteral.age}");



            ////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("\n----------- hw3 ----------"); // реализовать классы...банк клиент счет
            Bankomat.ClientNamespace.Client client = new Bankomat.ClientNamespace.Client("Abu", 18);
            Bankomat.BankNamespace.Bank bank = new Bankomat.BankNamespace.Bank();
            //Console.WriteLine($"BillNumber: {client.account.BillNumber}\n" +
            //    $"Password: {client.account.Password}");

            bank.OpenBillInBank(ref client);

            Console.WriteLine($"BillNumber: {client.account.BillNumber}\n" +
               $"Password: {client.account.Password}");
        }
    }
}
