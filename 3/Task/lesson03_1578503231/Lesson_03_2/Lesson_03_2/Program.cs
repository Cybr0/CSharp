using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "String one";
            string str2 = new string('A', 10);

            char[] char_array = new char[] {'a','b','c','d'};
            string str3 = new string(char_array);
            string str4 = new string(char_array, 0, 3);
            Console.WriteLine(str4);

            Console.WriteLine(@"C:\""data""\myfile.txt'''''");
            int size = 10;
            int data = 333;
            Console.WriteLine("size={0}, data={1}", size, data);
            Console.WriteLine($"size={size}, data={data}");

            string test_string = "Строки неизменяемы, т. е. " +
                "содержимое созданного строкового объекта " +
                "изменить нельзя, хотя синтаксис выглядит " +
                "так, будто это возможно. Например, при написании к" +
                "ода компилятор фактически создает новый строковый " +
                "объект для хранения новой последовательности символов, " +
                "а затем этот новый объект назначается";

            if (test_string.EndsWith("тся"))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine(str1.IndexOf("n"));
            Console.WriteLine(str1.LastIndexOf("n"));

            var n_str = str1.Insert(4, "abcd");
            Console.WriteLine(str1);
            Console.WriteLine(n_str);

            Console.WriteLine(n_str.Remove(4));

            Console.WriteLine(n_str.Replace("abcd","xyz"));

            string sss = n_str.Substring(4, 4);
            Console.WriteLine(sss);

            var list = "file1.doc,file2.doc".Split(new char[] {','});
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
