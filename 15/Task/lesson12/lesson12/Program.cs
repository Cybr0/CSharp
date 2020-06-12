using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson12
{
    class TrafficLight
    {
        public delegate void LightChangeDelegate(Lights l);
        public enum Lights {l_red, l_yellow, l_green}
        public void Change()
        {
            if(cur_light < Lights.l_green)
            {
                cur_light++;
            }
            else
            {
                cur_light = Lights.l_red;
            }
            if (light_changed != null)
            {
                light_changed(cur_light);
            }
            if(light_changed_event != null)
            {
                light_changed_event(cur_light);
            }
        }
        public void RegisterCallback(LightChangeDelegate dlgt)
        {
            light_changed += dlgt;
        }
        public void UnregisterCallback(LightChangeDelegate dlgt)
        {
            light_changed -= dlgt;
        }
        private LightChangeDelegate light_changed;

        private Lights cur_light;
        public event LightChangeDelegate light_changed_event;

    }
    class Program
    {
        public delegate void MyDelegate(string d);//delegate
        static void Main(string[] args)
        {
            int tmp_var = 0;
            MyDelegate md = delegate (string val) {
                                tmp_var++;
                                Console.WriteLine("anonimus:{0}",val);
                            };
            md += ShowSome;
            md += (string val) =>
            {
                tmp_var++;
                Console.WriteLine("lambda:{0}", val);
            };

            md("Hello world");
            
            foreach(var item in md.GetInvocationList())
            {
                item.DynamicInvoke("foreach");
            }

            TrafficLight tl_obj = new TrafficLight();
            /*tl_obj.RegisterCallback(
                new TrafficLight.LightChangeDelegate(DrawTrafficLights));
            tl_obj.RegisterCallback(
                new TrafficLight.LightChangeDelegate(OpenGates));*/

            //tl_obj.RegisterCallback(DrawTrafficLights);
            //tl_obj.RegisterCallback(OpenGates);
            tl_obj.light_changed_event += DrawTrafficLights;
            tl_obj.light_changed_event += OpenGates;
            tl_obj.Change();
            tl_obj.Change();
            tl_obj.Change();
            //tl_obj.UnregisterCallback(OpenGates);
            tl_obj.light_changed_event -= OpenGates;
            Console.WriteLine("Gates are broken");
            tl_obj.Change();
            tl_obj.Change();
        }
        public static void ShowMessage()
        {
            Console.WriteLine("Hi from delegate");
        }
        public static void ShowSome(string v)
        {
            Console.WriteLine("ShowSome {0}",v);
        }

        public static void DrawTrafficLights(TrafficLight.Lights light)
        {
            var c_c = Console.ForegroundColor;
            switch (light)
            {
                case TrafficLight.Lights.l_red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("RED");
                    break;
                case TrafficLight.Lights.l_yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("YELLOW");
                    break;
                case TrafficLight.Lights.l_green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GREEN");
                    break;
            }
            Console.ForegroundColor = c_c;
        }
        public static void OpenGates(TrafficLight.Lights light)
        {
            switch (light)
            {
                case TrafficLight.Lights.l_red:
                case TrafficLight.Lights.l_yellow:
                    Console.WriteLine("Gates are closed");
                    break;
                case TrafficLight.Lights.l_green:
                    Console.WriteLine("Gates are opened");
                    break;
            }
        }
    }
}
