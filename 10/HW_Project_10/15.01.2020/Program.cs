using System;

namespace _15._01._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            // КОНВЕРТАЦИЯ С ДВУХ ВАЛЮТ
            // 1 USD = 955 UZS

            Console.WriteLine("1 часть программы\n");
            #region 1 часть программы
            //Console.WriteLine("Hello World!");
            Curency usd = new Curency("USD");
            usd.Value = 123;
            Console.WriteLine(usd.ToString());

            Curency uzb = new Curency("USD");
            uzb.Value = 123;
            Console.WriteLine(uzb.ToString());
            try
            {
                uzb += usd;
                Console.WriteLine(uzb.ToString());
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Exception: {ex.Message}");



            }

            uzb++;
            ++uzb;
            Console.WriteLine(uzb.ToString());
            Console.WriteLine(uzb);
            #endregion

            #region 2 часть программы  class ConvertCurency

            Console.WriteLine("\n2 часть программы  class ConvertCurency\n");
            Curency uzs_curence = new Curency("UZS");
            Curency usd_curence = new Curency("USD");
            uzs_curence.Value = 955;
            usd_curence.Value = 2;
            ConvertCurency convertCurency = new ConvertCurency();
            Console.WriteLine("до конвертации:\t\t" + usd_curence.ToString());
            convertCurency.Convert(ref usd_curence, uzs_curence);
            Console.WriteLine("после конвертации:\t" + usd_curence.ToString());
            convertCurency.Convert(ref usd_curence, "USD");
            Console.WriteLine("обратная конвертации:\t" + usd_curence.ToString());
            #endregion
        }
    }
}
