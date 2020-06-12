using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separator = { ' ', '.', ',' };
            
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            Dictionary<string, int> dict = new Dictionary<string, int>();
            
            for (int i = 0; i < text.Split(separator).Length; i++)
            {
                if (dict.ContainsKey(text.Split(separator)[i]))
                {
                    dict[text.Split(separator)[i]] += 1;
                }
                else
                {
                    dict.Add(text.Split(separator)[i], 1);
                }
            }
           
            Console.WriteLine(text + "\n\n");
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
            Console.WriteLine("\n");

            #region TODO: автоматизация окончаний
            /*
             * char[] wordSep = { 'а', 'е', 'у' };
             * 
             * 
                                 bool chek = true;
                    for (int wordSepIter = 0; wordSepIter < wordSep.Length; wordSepIter++)
                    {
                        if (dict.ContainsKey((text.Split(separator)[i]).Split(wordSep)[wordSepIter]))
                        {
                            dict[(text.Split(separator)[i].Split(wordSep)[wordSepIter])] += 1;
                            chek = false;
                            break;
                        }
                    }
                    if (!chek)
                    {
                        dict.Add(text.Split(separator)[i], 1);
                    }
             */
            #endregion
        }
    }
}
