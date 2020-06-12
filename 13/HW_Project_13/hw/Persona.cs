using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    abstract class Persona
    {
        abstract public void Info();
        abstract public void HowOld();
        abstract public DateTime BirthDay { get; }
    }

    class Enrollee : Persona
    {
        public Enrollee(string surname, DateTime birthDay, string faculty)
        {
            this.surname = surname;
            this.birthDay = birthDay;
            this.faculty = faculty;
        }
        private string surname;
        private DateTime birthDay;
        private string faculty;
        public override DateTime BirthDay { get { return birthDay; } }
        public override void Info()
        {
            Console.WriteLine($"Фамилия:\t{surname}\n" +
                $"Дата рождения:\t{birthDay.ToShortDateString()}\n" +
                $"Факультет:\t{faculty}");
        }
        public override void HowOld()
        {
            Console.WriteLine($"Возвраст: {(DateTime.Now.Year - birthDay.Year)} лет.");
        }
    }

    class Student : Persona
    {
        public Student(string surname, DateTime birthDay, string faculty, int course)
        {
            this.surname = surname;
            this.birthDay = birthDay;
            this.faculty = faculty;
            this.course = course;
        }
        private string surname;
        private DateTime birthDay;
        private string faculty;
        private int course;
        public override DateTime BirthDay{ get { return birthDay; } }
        public override void Info()
        {
            Console.WriteLine($"Фамилия:\t{surname}\n" +
                $"Дата рождения:\t{birthDay.ToShortDateString()}\n" +
                $"Факультет:\t{faculty}\n" +
                $"Курс:\t{course}");
        }
        public override void HowOld()
        {
            Console.WriteLine($"Возвраст: {(DateTime.Now.Year - birthDay.Year)} лет.");
        }
    }

    class Teacher : Persona
    {
        public Teacher(string surname, DateTime birthDay, string faculty, string position, int experience)
        {
            this.surname = surname;
            this.birthDay = birthDay;
            this.faculty = faculty;
            this.position = position;
            this.experience = experience;
        }
        private string surname;
        private DateTime birthDay;
        private string faculty;
        private string position;
        private int experience;
        public override DateTime BirthDay { get { return birthDay; } }
        public override void Info()
        {
            Console.WriteLine($"Фамилия:\t{surname}\n" +
                $"Дата рождения:\t{birthDay.ToShortDateString()}\n" +
                $"Факультет:\t{faculty}\n" +
                $"Должность:\t{position}\n" +
                $"Стаж:\t{experience}");
        }
        public override void HowOld()
        {
            Console.WriteLine($"Возвраст: {(DateTime.Now.Year - birthDay.Year)} лет.");
        }
    }
}
