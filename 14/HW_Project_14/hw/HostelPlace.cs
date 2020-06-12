using System;
using System.Collections.Generic;
using System.Text;

namespace hw
{
    enum Gender
    {
        male,
        female
    }

    enum FormOfStudy
    {
        full_time,
        distance
    }

    struct AverageScore
    {
        public AverageScore(double math, double inglish)
        {
            this.math = math;
            this.inglish = inglish;
        }
        public double Math
        {
            set { math = value; }
            get { return math; }
        }
        public double Inglish
        {
            set { inglish = value; }
            get { return inglish; }
        }
        private double math;
        private double inglish;
        public double TheAverageScore
        {
            get 
            { 
                return ((math + inglish) / 2); 
            }
        }
    }
    struct HostelPlace
    {
        public HostelPlace(string fullName, string group, double averageScore, double incomePerFamilyMember,int familyComposition, Gender gender, FormOfStudy form)
        {
            this.fullName = fullName;
            this.group = group;
            this.averageScore = averageScore;
            this.incomePerFamilyMember = incomePerFamilyMember;
            this.familyComposition = familyComposition;
            this.gender = gender;
            this.formOfStudy = form;

        }
        private string fullName;
        public string FullName { set { fullName = value; } get { return fullName; } }
        private string group;
        public string Group { set { group = value; } get { return group; } }
        private double averageScore;
        public double AverageScore { set { averageScore = value; } get { return averageScore; } }
        private double incomePerFamilyMember;
        public double IncomePerFamilyMember { set { incomePerFamilyMember = value; } get { return incomePerFamilyMember; } }
        private int familyComposition;
        public int FamilyComposition { set { familyComposition = value; } get { return familyComposition; } }
        private Gender gender;
        public Gender Gender { set { gender = value; } get { return gender; } }
        private FormOfStudy formOfStudy;
        public FormOfStudy FormOfStudy { set { formOfStudy = value; } get { return formOfStudy; } }
        public void Info()
        {
            Console.WriteLine($"ФИО:\t\t{FullName}\n" +
                $"Группа:\t\t{Group}\n" +
                $"Средний балл:\t{AverageScore}\n" +
                $"Доход нчс:\t{IncomePerFamilyMember}\n" +
                $"Состав семьи:\t{FamilyComposition}\n" +
                $"Пол:\t\t{Gender}\n" +
                $"Форма обучения:\t{FormOfStudy}");
        }

        public static void FillOutForm(ref HostelPlace student)
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
    }
}
