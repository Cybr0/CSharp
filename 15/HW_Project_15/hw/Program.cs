using System;
using System.IO;
using System.Reflection;


public class Example
{
    public static void Main()
    {
        Action outputMessage = null;
        outputMessage += Foo1;
        outputMessage += Foo2;
        outputMessage += Foo3;
        outputMessage += Foo4;
        outputMessage += Foo5;
        outputMessage += Foo6;
        outputMessage += Foo7;




        for (int i = 0; i < outputMessage.GetInvocationList().Length; i++)
        {
            
            var outputMsg = outputMessage.GetInvocationList()[i];
            try
            {
                Console.Write($"{i+1}) ");
                var a = outputMessage.Method;
                a.();
               // outputMsg.DynamicInvoke();
                
            }
            catch (Exception e)
            {

                Console.WriteLine($"{outputMsg.GetMethodInfo()} Error: {e.Message}");
            }
            
            
        }
        
    }

    private static void Foo1()
    {
        int a = 3, b = 3;
        int c = a / b;
        Console.WriteLine("Void Foo1() - отработал нормально.");
    }
    private static void Foo2()
    {
        int a = 3, b = 0;
        int c = a / b;
        Console.WriteLine("Void Foo2() - отработал нормально.");
    }

    private static void Foo3()
    {
        int a = 3, b = 2;
        int c = a / b;
        Console.WriteLine("Void Foo3() - отработал нормально.");
    }

    private static void Foo4()
    {
        int a = 3, b = 2;
        int c = a / b;
        throw new IndexOutOfRangeException("Выход за пределы массива.");
        Console.WriteLine("Void Foo4() - отработал нормально.");
    }

    private static void Foo5()
    {
        int a = 3, b = 2;
        int c = a / b;
        Console.WriteLine("Void Foo5() - отработал нормально.");
    }

    private static void Foo6()
    {
        int a = 3, b = 2;
        int c = a / b;
        Console.WriteLine("Void Foo6() - отработал нормально.");
    }

    private static void Foo7()
    {
        int a = 3, b = 2;
        int c = a / b;
        Console.WriteLine("Void Foo7() - отработал нормально.");
    }


}