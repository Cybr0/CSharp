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
            Console.Write("Введите текст: ");
            string str =  Console.ReadLine();

            string[] arrStr =  str.Split(' ');

            Console.WriteLine("Эти слова нач. и закан. на один и тот же символ:");
            foreach (var item in arrStr)
            {
                //наверное можно и так...
                //bool xmm = (item.StartsWith($"{item[0]}") == item.EndsWith($"{item[0]}"))  
                //    && item.StartsWith($"{item[0]}") 
                //    && item.EndsWith($"{item[0]}"); 
                // if (xmm) {...}
                
                if (item[0] == item[(item.Length - 1)])  // && item.Length > 1  // можно не учитывать слова которые состоят из одного символа
                {
                    Console.WriteLine(item);
                }
            }
            
        }
    }
}
