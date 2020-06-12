using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Linq;
using System.IO;

namespace hw24
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory() + @"\DATA\Country.csv";
            string path2 = Directory.GetCurrentDirectory() + @"\DATA\Country.xml";

            string[] sourse = File.ReadAllLines(path);
            string[] new_sourse = new string[sourse.Length - 1];

            for (int i = 1, j = 0; i < sourse.Length; i++, j++)
            {
                new_sourse[j] = sourse[i];
            }

            XElement element = new XElement(
                "COUNTRIES", from str in new_sourse
                             let fields = str.Split(';')
                           select new XElement(
                "Country",
                new XElement("Code", fields[0]),
                new XElement("Name", fields[1]),
                new XElement("Continent", fields[2]),
                new XElement("Region", fields[3]),
                new XElement("SurfaceArea", fields[4]),
                new XElement("IndepYear", fields[5]),
                new XElement("Population", fields[6]),
                new XElement("LifeExpectancy", fields[7]),
                new XElement("GNP", fields[8]),
                new XElement("GNPOld", fields[9]),
                new XElement("LocalName", fields[10]),
                new XElement("GovernmentForm", fields[11]),
                new XElement("HeadOfState", fields[12]),
                new XElement("Capital", fields[13]),
                new XElement("Code2", fields[14])
                ));

            Console.WriteLine(element);

            XDocument document = new XDocument();
            document.Add(element);
            document.Save(path2);
        }
    }
}
