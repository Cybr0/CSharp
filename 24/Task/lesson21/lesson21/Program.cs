using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            XElement n_element = new XElement("Students",
                new XElement("Student", 
                    new XElement("name", "John"),
                    new XAttribute("color", "red"),
                    new XAttribute("age", 18),
                    new XElement("cource", 2)),
                new XElement("Student", 
                    new XElement("name", "Jane"),
                    new XElement("cource", 1)));

            //Console.WriteLine(n_element);

            XDocument x_doc = new XDocument();
            x_doc.Add(n_element);

            Console.WriteLine(x_doc);
            x_doc.Save("D:\\test_files\\doc.xml");

            n_element.Save("D:\\test_files\\element.xml");
            */

            XDocument read_doc = XDocument.Load("D:\\test_files\\doc.xml");

            //Console.WriteLine(read_doc);
            var elems = read_doc.Descendants("cource");
            foreach (var e in elems)
            {
                //Console.WriteLine(e);
            }

            var nodes = read_doc.Descendants("Student").First<XElement>();

            //Console.WriteLine(nodes);

            //Console.WriteLine(nodes.NextNode);

            //Console.WriteLine(nodes.NextNode.PreviousNode);

            XNode t_node = nodes;
            
            while (t_node != null)
            {
                Console.WriteLine(t_node.ToString());
                t_node = t_node.NextNode;
            }
            Console.WriteLine(nodes.Parent);

            Console.WriteLine("------------------------------------");
            XElement data_node = read_doc.Element("Students")
                .Elements("Student")
                .Where(i => (string)i.Element("name") == "John")
                .Single<XElement>();
            data_node.SetElementValue("cource", 3);

            Console.WriteLine(data_node);
            Console.WriteLine("------------------------------------");
            data_node.AddAfterSelf(new XElement("Student",
                    new XElement("name", "Clara"),
                    new XElement("cource", 3)));

            data_node.AddBeforeSelf(new XElement("Student",
                    new XElement("name", "Clark"),
                    new XElement("cource", 4)));
            data_node.Remove();
            Console.WriteLine(read_doc);

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            IEnumerable<XElement> elements =
                from e in read_doc.Descendants("Student")
                where (string)e.Element("name") == "Jane"
                select e;

            foreach (var x in elements)
            {
                Console.WriteLine(x);
            }
        }
    }
}
