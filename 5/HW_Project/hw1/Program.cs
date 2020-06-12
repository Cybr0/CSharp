using System;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker a = null;
            try
            {
                a.tmp = 4;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("catch (NullReferenceException ex)");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("catch (Exception ex)");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
