using System;
using System.Collections.Generic;
using System.Xml;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load("phones.xml");
            foreach (XElement phoneElement in xdoc.Element("phones").Elements("phone"))
            {
                XAttribute nameAttribute = phoneElement.Attribute("name");
                XElement companyElement = phoneElement.Element("company");
                XElement priceElement = phoneElement.Element("price");

                if (nameAttribute != null && companyElement != null && priceElement != null)
                {
                    Console.WriteLine($"Смартфон: {nameAttribute.Value}");
                    Console.WriteLine($"Компания: {companyElement.Value}");
                    Console.WriteLine($"Цена: {priceElement.Value}");
                }
                Console.WriteLine();
            }
        }
        static void LoadXML()
        {
            XDocument xdoc = XDocument.Load("phones.xml");
            var items = from xe in xdoc.Element("phones").Elements("phone")
                        where xe.Element("company").Value == "Samsung"
                        select new Phone
                        {
                            Name = xe.Attribute("name").Value,
                            Price = xe.Element("price").Value
                        };

            foreach (var item in items)
                Console.WriteLine($"{item.Name} - {item.Price}");
        }
    }
    class Phone
    {
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
