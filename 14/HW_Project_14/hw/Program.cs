using System;

namespace hw
{
    class Program
    {
        #region метод для 3 способа
        static void FillOutForm(ref HostelPlace student)
        {
            Console.Write($"Заполните Форму.\n" +
                $"ФИО: ");
            student.FullName = Console.ReadLine();
            Console.Write("Группа: ");
            student.Group = Console.ReadLine();
            Console.Write("Средний балл: ");
            student.AverageScore = double.Parse(Console.ReadLine());
            Console.Write("Доход нчс: ");
            student.IncomePerFamilyMember = double.Parse(Console.ReadLine());
            Console.Write("Состав семьи: ");
            student.FamilyComposition = int.Parse(Console.ReadLine());
            Console.Write("Пол: ");
            student.Gender = (Gender)int.Parse(Console.ReadLine());
            Console.Write("Форма обучения: ");
            student.FormOfStudy = (FormOfStudy)int.Parse(Console.ReadLine());
        }
        #endregion
        static void Main(string[] args)
        {
            #region 1способ
            HostelPlace abu = new HostelPlace("Ivanov Abu Alievich", "620-б", new AverageScore(5, 4).TheAverageScore, 2000, 5, Gender.male, FormOfStudy.full_time);
            abu.Info();
            Console.WriteLine("\n\n");
            #endregion

            #region 2способ(через стат. метод структуры)
            HostelPlace ali = new HostelPlace();
            HostelPlace.FillOutForm(ref ali);
            Console.WriteLine("\n\n");
            ali.Info();
            #endregion

            #region 3способ
            HostelPlace strudent = new HostelPlace();
            FillOutForm(ref strudent);
            #endregion
        }
    }
}
