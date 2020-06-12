using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace hw22
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"C://XMLCountryList.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            //--------------------------------------------------------------
            #region 7
            Dictionary<string, int> dict = new Dictionary<string, int>();
            Dictionary<string, int> dictFor = new Dictionary<string, int>();
            string []abc =  {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L","M",
                "N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
                };
            foreach (var key in abc)
            {
                dict.Add(key, 0);
                dictFor.Add(key, 0);
            }
            #endregion

            #region 8
            Dictionary<string, int> country = new Dictionary<string, int>();
            country.Add("asia", 0);
            country.Add("europe", 0);
            country.Add("africa", 0);
            country.Add("north america", 0);
            country.Add("antarctica", 0);
            country.Add("south america", 0);
            country.Add("australia", 0);
            country.Add("central america", 0);

            #endregion
            //--------------------------------------------------------------

            #region 9
            int countFor9Ex = 0;
            List<string> arr9 = new List<string>();
            #endregion
            //--------------------------------------------------------------
            #region 5
            Console.WriteLine("5. All countries:" +
                "\n------------------------------");
            foreach (XmlNode xnode in xRoot)
            {
                Console.WriteLine(xnode.InnerText);
                foreach (var key in dictFor)
                {
                    if (xnode.InnerText.StartsWith(key.Key))
                    {
                        dict[key.Key] += 1;
                    }
                }
            }
            #endregion

            #region 6.1
            Console.WriteLine("\n\n##################################\n\n");
            Console.WriteLine("6.1. Countries of South and North America:" +
                "\n------------------------------");
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("continent");
                    if (attr != null)
                    {
                        if (attr.Value == "south america" || attr.Value == "north america")
                        {
                            Console.WriteLine(xnode.InnerText);
                        }
                    }
                    if (country.ContainsKey(attr.Value))
                    {
                        country[attr.Value] += 1;
                    }
                }
            }
            #endregion

            #region 6.2
            Console.WriteLine("\n\n##################################\n\n");
            Console.WriteLine("6.2. Countries of Asia and Africa:" +
                "\n------------------------------");
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("continent");
                    if (attr != null)
                    {
                        if (attr.Value == "asia" || attr.Value == "africa")
                        {
                            Console.WriteLine(xnode.InnerText);
                        }
                        // 9 задание
                        if (xnode.InnerText.Contains(" "))
                        {
                            countFor9Ex += 1;
                            arr9.Add(xnode.InnerText);
                        }
                        // 9 
                    }
                }
            }
            #endregion


            #region 7
            Console.WriteLine("\n\n##################################\n\n");
            Console.WriteLine("7.:" +
                "\n------------------------------");
            foreach (var item in dict)
            {
                Console.WriteLine($"Unit count for {item.Key} = {item.Value}");
            }
            #endregion

            #region 8
            Console.WriteLine("\n\n##################################\n\n");
            Console.WriteLine("8. Total contries in a Continent:" +
                "\n------------------------------");
            foreach (var item in country)
            {
                Console.WriteLine($"Continent {item.Key}: {item.Value} countries.");
            }
            #endregion

            #region 9
            Console.WriteLine("\n\n##################################\n\n");
            Console.WriteLine("9.:" +
                "\n------------------------------");
            Console.WriteLine($"Countries: {countFor9Ex}");
            foreach (var item in arr9)
            {
                Console.WriteLine($"{item}");
            }
            #endregion
            Console.WriteLine("\n");
        }
    }
}
