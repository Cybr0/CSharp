using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lesson18
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("data.xml");
                XmlElement root = doc.DocumentElement;
                
                Console.WriteLine(root.Name);
                
                Console.WriteLine("#########################");
                foreach (XmlNode node in root)
                {
                    Console.WriteLine(node.Name);
                    XmlNode idAtr = node.Attributes.GetNamedItem("id");
                    if (idAtr != null)
                    {
                        Console.WriteLine($"id={idAtr.Value}");
                    }
                    foreach (XmlNode item in node)
                    {
                        Console.WriteLine($"{item.Name}:{item.InnerText}");
                    }
                    //Console.WriteLine($"{node.Name}:{node.InnerText}");
                    Console.WriteLine("--------------------");
                }

            }
            catch(XmlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                XmlDocument newXml = new XmlDocument();
                XmlNode root = newXml.CreateElement("books");

                XmlNode book = newXml.CreateElement("book");
                XmlAttribute atr = newXml.CreateAttribute("id");
                atr.Value = "1";
                book.Attributes.Append(atr);

                XmlNode name = newXml.CreateElement("name");
                name.InnerText = "C++";
                book.AppendChild(name);

                XmlNode autor = newXml.CreateElement("autor");
                autor.InnerText = "Straustrup";
                book.AppendChild(autor);

                XmlNode publisher = newXml.CreateElement("publisher");
                publisher.InnerText = "press";

                book.AppendChild(publisher);

                root.AppendChild(book);

                newXml.AppendChild(root);

                newXml.Save("book.xml");
            }
            catch (XmlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
