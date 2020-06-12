using System;
using System.Collections.Generic;

namespace _10._02._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //var rnd = new Random();
            //List<int> list = new List<int>();

            //const int SIZE = 5;
            //for (int i = 0; i < SIZE; i++)
            //{
            //    list.Add(rnd.Next(20));
            //    Console.WriteLine(list[i]);
            //}

            ////list.Sort();


            //int jiter = 0;
            //int max = list[jiter];
            //int maxPrev = max;
            //bool cheack = false;


            //while (!cheack) { 
            //    for (int i = 0; i < SIZE; i++)
            //    {
            //        if(max < list[i])
            //        {
            //            maxPrev = max;
            //            max = list[i];
            //            cheack = true;
            //        }
            //    }
            //    if(cheack == false)
            //    {
            //        max = list[jiter++];
            //        maxPrev = max;
            //    }
            //}


            //Console.WriteLine($"Ответ: {maxPrev}  индех: {list.IndexOf(maxPrev)}");
            //int sumCh = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (i % 2 == 0 && i != 0)
            //    {
            //        sumCh += list[i];
            //    }
            //}
            //Console.WriteLine($"Ответ: сумма четных: {sumCh}");
            //#endregion

            //#region 2
            //for (int i = list.Count - 1; i >= 0 ; i--)
            //{
            //    if(i % 2 != 0)
            //    {
            //        list.RemoveAt(i);
            //    }

            //}

            //Console.WriteLine("2 задание: delete nechot element.");
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //#endregion

            //#region 3
            //List<double> list3 = new List<double>();
            //double average = 0;
            //for (int i = 0; i < SIZE; i++)
            //{
            //    list3.Add(rnd.Next(20));
            //    average += list3[0];
            //}
            //average /= SIZE;

            //Console.WriteLine($"average: {average}");
            //for (int i = 0; i < list3.Count; i++)
            //{
            //    if(list3[i] > average)
            //    {
            //        Console.WriteLine(list3[i]);
            //    }
            //}


            #endregion

            #region 4
            string text = "Some a text to cheak this exercize";
            string text2 = "";

            Console.WriteLine(text);
            for (int i = text.Length - 1; i >= 0 ; i--)
            {
                text2 += text[i];
                
            }
            Console.Write(text2);
            #endregion


            #region 5
            bool cheakText = true;
            for (int i = 0, j = text2.Length - 1; i < text.Length; i++, j--)
            {
                if (text[i] != text2[j])
                {
                    Console.WriteLine("\nНеявляется обратной!");
                    cheakText = false;
                    break;
                }

            }
            if (cheakText == true)
            {
                Console.WriteLine("\nЯвляется обратной!");
            }
            #endregion

            #region 6
            //Console.WriteLine(text.Equals(" "));
            string newString = "";
            for (int i = 0; i < text.Length; i++)
            {
                if(i == 0 || text[(i - 1)] == ' ')
                {
                    if(text[i] == 'e' ||
                        text[i] == 'y' ||
                        text[i] == 'u' ||
                        text[i] == 'i' ||
                        text[i] == 'o' ||
                        text[i] == 'a')
                    {
                        while ((i < text.Length) && (text[i] != ' '))
                        {
                            newString += text[i];
                            i++;
                        }
                        newString += ' ';
                        
                    }
                    
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0 || text[(i - 1)] == ' ')
                {
                    if (text[i] != 'e' &&
                        text[i] != 'y' &&
                        text[i] != 'u' &&
                        text[i] != 'i' &&
                        text[i] != 'o' &&
                        text[i] != 'a')
                    {
                        while ((i < text.Length) && (text[i] != ' '))
                        {
                            newString += text[i];
                            i++;
                        }
                        newString += ' ';
                       
                    }

                }
            }

            //text.Split()
            Console.WriteLine("\n\n" + text);
            Console.WriteLine(newString);
            #endregion

            #region 7
            string someNumbers = "-5,10,5,-45,-4,-3,3,2,1,5";
            #endregion
        }
    }
}
