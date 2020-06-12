using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_05
{
    class Program
    {
        public static void someFung()
        {
            var ex = new Exception("Some error");
            ex.HelpLink = "google.com";
            throw ex;
        }
        public static void someF(Exception s)
        {
            Console.WriteLine(s);
        }
        static void test_method(string a, string b)
        {
            if(a == null || b == null)
            {
                throw new ArgumentNullException();
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            bool b_val = false;
            string a_str = "some str a";
            string b_str = null;
            try
            {

                test_method(a_str, b_str);
                /*
                int a = 999999999;
                int b = 999999999;
                checked //unchecked
                {
                    b = b * a;
                }
                Console.WriteLine(b);
                */
                //someFung();
                //int[] arr = new int[2];
                //arr[3] = 0;

            }
            catch (IndexOutOfRangeException exep)
            {
                Console.WriteLine("IndexOutOfRangeException");
                Console.WriteLine(exep.Message);
            }
            catch (ArgumentNullException e) when(a_str == null)
            {
                Console.WriteLine("a string null");
            }
            catch (ArgumentNullException e) when (b_str == null)
            {
                Console.WriteLine("b string null");
            }
            catch (Exception exep) when (b_val)
            {
                Console.WriteLine("Exception b_val = true");
                Console.WriteLine(exep.Message);
            }
            catch (Exception exep)
            {
                Console.WriteLine("Exception");
                Console.WriteLine(exep.Message);
            }
            finally
            {
                Console.WriteLine("Final code");
            }
        }
    }
}
