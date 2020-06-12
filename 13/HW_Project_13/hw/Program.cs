using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class Program
    {
        #region static void searchByAge(Persona []arr);
        static void searchByAge(Persona []arr)
        {
            Console.Write("Введите диапазон.\n" +
                "С какого года: ");
            int Year_1 = int.Parse(Console.ReadLine());
            
            Console.Write("По какой год: ");
            int tmpYear_2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].BirthDay.Year >= Year_1 && arr[i].BirthDay.Year <= tmpYear_2)
                {
                    arr[i].Info();
                    Console.WriteLine();
                }
            }
        }
        #endregion
        static void Main(string[] args)
        { 
            Enrollee enrollee = new Enrollee("Волков", new DateTime(2002, 05, 11), "Физика");
            Student student = new Student("Ведьмаков", new DateTime(2000, 12, 07), "Физика", 2);
            Teacher teacher= new Teacher("Ривийский", new DateTime(1965, 07, 26), "Физика", "Доктор наук", 40);

            Persona[] arr = new Persona[3];
            arr[0] = enrollee;
            arr[1] = student;
            arr[2] = teacher;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Info();
                arr[i].HowOld();
                Console.WriteLine("-----   -----   -----   -----\n");
            }

            searchByAge(arr);
        }
    }
}
