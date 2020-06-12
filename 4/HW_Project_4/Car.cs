using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    partial class Car
    {
        static char steeringWeel; //r- right sw, l- left sw
        public static bool engine;
        private string carName;
        private int wheel;
        private float wheelRadius;
        private double carSpeed;
        private double maxCarSpeed;
        private char carClass; // driverLicenseCategory;

       



        static Car()
        {
            engine = true;
            steeringWeel = 'l';
        }
        public Car() : this("carName", 4, 20) { }
        public Car(char carClass) : this("carName", 4, 20)
        {
            this.carClass = carClass;
        }
        public Car(double carSpeed, double maxCarSpeed) : this("carName", 4, 20)
        {
            this.maxCarSpeed = maxCarSpeed;
            this.carSpeed = carSpeed;
        }
        public Car(string carName, int wheel, float wheelRadius)
        {
            this.carName = carName;
            this.wheel = wheel;
            this.wheelRadius = wheelRadius;
        }



        public string GetCarName() { return carName; }
        public void SetCarName(string carName) { this.carName = carName; }

        public int Wheel { set { wheel = value; } get { return wheel; } }

        public void SetWheelRadius(ref int wheelRadius)
        {
            this.wheelRadius = wheelRadius;
        }

        public void StartTheCar() //start the engine
        {
            Console.WriteLine("void StartTheCar()");
        }
        public void OpenCarDoor()
        {
            Console.WriteLine("void OpenCarDoor()");
        }

        public void Drive()
        {
            Console.WriteLine("void Drive()");
        }

       // public static Car Fabric { get { return new Car(); } }
      //  public static Car DoFabric() { return new Car(); }

        //public Car this[int i] { 
        //    get { return new Car(); } 
        //    set { } }

    }
}
