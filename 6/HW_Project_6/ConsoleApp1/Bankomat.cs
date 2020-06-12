using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    namespace BankNamespace
    {
        class Bank
        {
            public ClientNamespace.Client OpenBillInBank(ref ClientNamespace.Client client)
            {
                if (!client.account.Bill && client.Age >= 18)
                {
                    client.account.Bill = true;
                    client.account.BillNumber = new Random().Next(1000, 10000);
                    client.account.Password = $"abc{new Random().Next(1, 100)}@p";
                }
               
                return client;
            }
        }

    }

    namespace ClientNamespace
    {
        class Client
        {
            public Client(string name, int age)
            {
                this.name = name;
                this.Age = age;
                account = new AccountNamespace.Account();
            }

            public AccountNamespace.Account account;
            private string name;
            public int Age { set; get; }
        }
    }


    namespace AccountNamespace
    {
        class Account
        {
            public Account()
            {
                Bill = false;
                BillNumber = 0;
                Password = "";
            }
            public bool Bill { set; get; } //счет
            public int BillNumber { set; get; }
            public string Password { set; get; }
        }
    }
}
