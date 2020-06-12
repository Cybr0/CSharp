using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03._2020
{
    public delegate void deleg();

    public class City
    {
        public City()
        {
            eСrime = Police.DoWork;
            eСrime += Ambulance.Waiting;
            eСrime += FireDepartment.Waiting;

            eFire = Police.Waiting;
            eFire += Ambulance.Waiting;
            eFire += FireDepartment.DoWork;

            eNeedAmbulance = Police.Waiting;
            eNeedAmbulance += Ambulance.DoWork;
            eNeedAmbulance += FireDepartment.Waiting;
        }
        private event deleg eFire;
        private event deleg eСrime;
        private event deleg eNeedAmbulance;

        public void Fire()
        {
            if (eFire != null)
            {
                eFire();
            }
        }

        public void Сrime()
        {
            if (eСrime != null)
            {
                eСrime();
            }
        }

        public void NeedAmbulance()
        {
            if (eNeedAmbulance != null)
            {
                eNeedAmbulance();
            }
        }
    }

    public static class Police
    {
        public static void Waiting()
        {
            Console.WriteLine("Police: Патрулирование города");
        }
        public static void DoWork()
        {
            Console.WriteLine("Police: Выезд на запрос.");
        }
    }

    public static class Ambulance
    {
        public static void Waiting()
        {
            Console.WriteLine("Ambulance: Ожидание");
        }
        public static void DoWork()
        {
            Console.WriteLine("Ambulance: Выезд.");
        }
    }

    public static class FireDepartment
    {
        public static void Waiting()
        {
            Console.WriteLine("FireDepartment: Ожидание");
        }
        public static void DoWork()
        {
            Console.WriteLine("FireDepartment: Выезд на пажар!");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            City NewCity = new City();
            deleg CityAction = NewCity.Fire;
            CityAction += NewCity.Сrime;
            CityAction += () => throw new Exception("Ошибка в Лямбда-Выражении.");
            CityAction += NewCity.NeedAmbulance;


            foreach (var item in CityAction.GetInvocationList())
            {
                try
                {
                    item.DynamicInvoke();
                    Console.WriteLine("##################");
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.InnerException);
                    Console.WriteLine("##################");
                }
                
            }
            


            #region тут пример отдельный для 1 задания
            /*
             * Console.WriteLine("Пажар в городе!!");
                
                NewCity.Fire();
                Console.WriteLine("######################");

                Console.WriteLine("Ограбили банк!!");
                NewCity.Сrime();
                Console.WriteLine("######################");

                Console.WriteLine("Человеку плохо!!");
                NewCity.NeedAmbulance();
                Console.WriteLine("######################");
             */
            #endregion

        }

    }
}
