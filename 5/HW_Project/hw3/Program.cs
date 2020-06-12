using System;

namespace hw3
{
    class Program
    {
        static void firstMethod()
        {
            Console.WriteLine("firstMethod(), тут будет брошено исключение...");
            throw new Exception("My Exception!");
        }
        static void secondMethod()
        {
            Console.WriteLine("secondMethod(), тут будет вызван firstMethod()");
            firstMethod();
        }
        static void zeroMethod()
        {
            Console.WriteLine("secondMethod(), тут будет вызван secondMethod()");
            secondMethod();
        }

        static void Main(string[] args)
        {
            try
            {
                zeroMethod();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"ОШИБКА: {ex.Message}");
                Console.WriteLine(ex.GetBaseException());
                //Console.WriteLine(ex.StackTrace); ну или так можно посмотреть откуда было брошено исключение
            }
        }
    }
}
