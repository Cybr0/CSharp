using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace hw21
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
    }
    class Library
    {
        public Library()
        {
            Books = new List<Book>();
        }

        public string Name { get; set; }
        public DateTime FoundDate { get; set; }
        public List<Book> Books { get; set; }

        public XmlNode ToXml(XmlDocument document)
        {
            try
            {
                XmlNode library = document.CreateElement("Library");

                XmlNode libName = document.CreateElement("Name");
                libName.InnerText = this.Name;

                XmlNode libFoundDate = document.CreateElement("FoundDate");
                libFoundDate.InnerText = this.FoundDate.ToString();

                XmlNode libBooks = document.CreateElement("Books");

                foreach (var item in this.Books)
                {
                    XmlNode book = document.CreateElement("book");
                    XmlAttribute atr = document.CreateAttribute("id");
                    atr.Value = item.Id.ToString();
                    book.Attributes.Append(atr);

                    XmlNode bookName = document.CreateElement("Name");
                    bookName.InnerText = item.Name;
                    book.AppendChild(bookName);

                    XmlNode bookAuthor = document.CreateElement("Author");
                    bookAuthor.InnerText = item.Author;
                    book.AppendChild(bookAuthor);

                    XmlNode bookPublisher = document.CreateElement("Publisher");
                    bookPublisher.InnerText = item.Publisher;
                    book.AppendChild(bookPublisher);

                    libBooks.AppendChild(book);

                }
                library.AppendChild(libName);
                library.AppendChild(libFoundDate);
                library.AppendChild(libBooks);
                return library;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;

        }
        public void SaveXml(string path)
        {
            XmlDocument document = new XmlDocument();
            document.AppendChild(ToXml(document));
            document.Save(path);
        }

        public void FromXml(XmlDocument document)
        {
            if (document == null)
            {
                throw new Exception("Файл пустой!");
            }
            XmlElement root = document.DocumentElement;
            foreach (XmlNode node in root)
            {
                if (node.Name == "Name")
                {
                    this.Name = node.InnerText;
                }
                else if (node.Name == "FoundDate")
                {
                    this.FoundDate = DateTime.Parse(node.InnerText);
                }
                else if (node.Name == "Books")
                {
                    
                    foreach (XmlNode item in node.ChildNodes)
                    {
                        Book tmp = new Book();
                        XmlNode idAtr = item.Attributes.GetNamedItem("id");
                        if (idAtr != null)
                        {
                            tmp.Id = int.Parse(idAtr.Value);
                        }
                        foreach (XmlNode item2 in item)
                        {
                            if (item2.Name == "Name")
                            {
                                tmp.Name = item2.InnerText;
                            }
                            else if (item2.Name == "Author")
                            {
                                tmp.Author = item2.InnerText;
                            }
                            else if (item2.Name == "Publisher")
                            {
                                tmp.Publisher = item2.InnerText;
                            }
                        }
                        this.Books.Add(tmp);
                    }
                    
                }
            }
        }
        public void LoadXml(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            FromXml(doc);
        }
        public void Info()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"FoundDate: {FoundDate.ToShortDateString()}\n" +
                $"Books:\n");
            foreach (var item in Books)
            {
                Console.WriteLine($"id: {item.Id}\n" +
                    $"Name: {item.Name}\n" +
                    $"Author: {item.Author}\n" +
                    $"Publisher: {item.Publisher}\n" +
                    $"-----------------------------\n");
            }
        }  
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 1) SaveFunc
            Book book1 = new Book();
            book1.Id = 1;
            book1.Name = "C++";
            book1.Author = "Straustrup";
            book1.Publisher = "press";

            Book book2 = new Book();
            book2.Id = 2;
            book2.Name = "C#";
            book2.Author = "Tim";
            book2.Publisher = "press";

            Book book3 = new Book();
            book3.Id = 3;
            book3.Name = "Java";
            book3.Author = "Timur";
            book3.Publisher = "Tashkent";

            Library library = new Library();
            library.Name = "LIB";
            library.FoundDate = new DateTime(2020, 01, 01);
            library.Books.Add(book1);
            library.Books.Add(book2);
            library.Books.Add(book3);

            XmlDocument xmlD = new XmlDocument();
            xmlD.AppendChild(library.ToXml(xmlD));
            xmlD.Save("testXml.xml");
            #endregion

            #region 2) LoadFunc
            XmlDocument doc = new XmlDocument();
            doc.Load("testXml.xml");

            Library test = new Library();
            test.FromXml(doc);
            test.Info();

            #endregion

            #region 3) check 2 func
            Library tLib = new Library();
            tLib.LoadXml("1.xml");
            tLib.Info();
            tLib.SaveXml("2.xml");
            #endregion
        }
    }
}
