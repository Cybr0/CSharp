using System;
using System.Collections.Generic;
using System.Xml;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("D://users.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            // выбор всех дочерних узлов
            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.OuterXml);

            // выбор всех узлов
            XmlNodeList childnodes = xRoot.SelectNodes("user");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.OuterXml);

            // вывод на консоль значения атрибутов name у всех элементов user
            XmlNodeList childnodes = xRoot.SelectNodes("user");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.SelectSingleNode("@name").Value);

            // выбор узла, у которого атрибут name имеет значение "Bill Gates"
            XmlNode childnode = xRoot.SelectSingleNode("user[@name='Bill Gates']");
            if (childnode != null)
                Console.WriteLine(childnode.OuterXml);

            // выбор узла, у которого вложенный элемент "company" имеет значение "Microsoft"
            XmlNode childnode = xRoot.SelectSingleNode("user[company='Microsoft']");
            if (childnode != null)
                Console.WriteLine(childnode.OuterXml);

            // если надо получить только компании, то для этого надо осуществить выборку вниз по иерархии элементов:
            XmlNodeList childnodes = xRoot.SelectNodes("//user/company");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.InnerText);
        }
    }
}
