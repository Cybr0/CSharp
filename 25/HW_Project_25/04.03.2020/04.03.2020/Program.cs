using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.IO;
using System.Collections;

namespace _04._03._2020
{
    [Serializable]
    public class Book
    {
        public Book()
        {
            id = itr++;
        }
        static int itr = 1;
        public int id;
        public string name;
        public string publisher;
        public string author;
        public int pages;

        public override string ToString()
        {
            return $"id: {id} \nname: {name}, \npublisher: {publisher}, \nauthor: {author}, \npages: {pages}";
        }

    }

    //[DataContract]
    [Serializable]
    [XmlInclude(typeof(Book))]
    public class Library
    {
        public Library()
        {
            books = new ArrayList();
        }
        //[DataMember]
        public ArrayList books;

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(int id)
        {
            books.RemoveAt(id);
        }

        public void SaveToBin(string file_name)
        {
            using (FileStream file = new FileStream(file_name, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, this);
            }
        }

        public void SaveToSOAP(string file_name)
        {
            using (FileStream s_file = new FileStream(file_name, FileMode.Create))
            {
                SoapFormatter bf = new SoapFormatter();
                Library library = new Library();
                bf.Serialize(s_file, this);
            }
        }

        public void SaveToSOAP2(string file_name)
        {
            Stream streamWrite = File.Create(file_name);
            SoapFormatter soapWrite = new SoapFormatter();
            soapWrite.Serialize(streamWrite, this);
            streamWrite.Close();
        }

        public void SaveToXml(string file_name)
        {
            using (FileStream fs = new FileStream(file_name, FileMode.Create))
            {
                XmlSerializer xml_ser = new XmlSerializer(typeof(Library));
                xml_ser.Serialize(fs, this);
            }
        }

        public void LoadFromBin(string file_name)
        {
            using (FileStream file = new FileStream(file_name,FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Library library = (Library)bf.Deserialize(file);
                this.books = library.books;
            }
        }

        public void LoadFromSOAP(string file_name)
        {
            using (FileStream d_file = new FileStream(file_name, FileMode.Open))
            {
                SoapFormatter bf_o = new SoapFormatter();
                Library library = (Library)bf_o.Deserialize(d_file);
                this.books = library.books;
            }
        }

        public void LoadFromXml(string file_name)
        {
            using (FileStream fs = new FileStream(file_name, FileMode.Open))
            {
                XmlSerializer xml_ser = new XmlSerializer(typeof(Library));
                Library library = (Library)xml_ser.Deserialize(fs);
                this.books = library.books;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book my_book = new Book();
            my_book.name = "New book";
            my_book.publisher = "Press";
            my_book.author = "Writer";
            my_book.pages = 300;

            Book my_book2 = new Book();
            my_book2.name = "book 2";
            my_book2.publisher = "Press 2";
            my_book2.author = "Writer 2";
            my_book2.pages = 100;

            Book my_book3 = new Book();
            my_book3.name = "book 3";
            my_book3.publisher = "Press 3";
            my_book3.author = "Writer 3";
            my_book3.pages = 100;

            
            Library lib = new Library();
            lib.books.Add(my_book);
            lib.books.Add(my_book2);
            lib.books.Add(my_book3);

            //lib.SaveToBin("test1.bin");
            //lib.SaveToSOAP("test2.soap");
            //lib.SaveToXml("test3.xml");

            //Library newLib = new Library();
            //newLib.LoadFromBin("test1.bin");
            //newLib.LoadFromSOAP("test2.soap");
            //newLib.LoadFromXml("test3.xml");


            //Console.WriteLine();
            //Console.WriteLine(newLib.books[0].ToString());

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню");
                Console.WriteLine("1. AddBook");
                Console.WriteLine("2. RemoveBook");
                Console.WriteLine("3. SaveToBin");
                Console.WriteLine("4. SaveToSOAP");
                Console.WriteLine("5. SaveToXml");
                Console.WriteLine("6. LoadFromBin");
                Console.WriteLine("7. LoadFromSOAP");
                Console.WriteLine("8. LoadFromXml");
                Console.WriteLine("9. Показать все книги");
                Console.WriteLine("10. Выход");
               int menu =  int.Parse(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case 1:
                        Book book = new Book();
                        Console.Write("Название книги: ");
                        string str = Console.ReadLine();
                        book.name = str;
                        Console.Write("\nНазвание издателя: ");
                        str = Console.ReadLine();
                        book.publisher = str;
                        Console.Write("\nИмя автора: ");
                        str = Console.ReadLine();
                        book.author = str;
                        Console.Write("\nКоличество страниц: ");
                        int p = int.Parse(Console.ReadLine());
                        book.pages = p;
                        lib.AddBook(book);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("Введите id книги: ");
                        int pp = int.Parse(Console.ReadLine());
                        lib.RemoveBook(pp);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("куда сохранить: ");
                        string str1 = Console.ReadLine();
                        lib.SaveToBin(str1);
                        Console.WriteLine($"Сохнанено в {str1}");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("куда сохранить: ");
                        string str2 = Console.ReadLine(); 
                        lib.SaveToSOAP(str2);
                        Console.WriteLine($"Сохнанено в {str2}");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("куда сохранить: ");
                        string str3 = Console.ReadLine();
                        lib.SaveToXml(str3);
                        Console.WriteLine($"Сохнанено в {str3}");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Write("откуда загрузить: ");
                        string str4 = Console.ReadLine();
                        lib.LoadFromBin(str4);
                        Console.WriteLine($"Загруженно с {str4}");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Write("откуда загрузить: ");
                        string str5 = Console.ReadLine();
                        lib.LoadFromSOAP(str5);
                        Console.WriteLine($"Загруженно с {str5}");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Write("откуда загрузить: ");
                        string str6 = Console.ReadLine();
                        lib.LoadFromXml(str6);
                        Console.WriteLine($"Загруженно с {str6}");
                        Console.ReadKey();
                        break;
                    case 9:
                        foreach (var item in lib.books)
                        {
                            Console.WriteLine(item);
                            Console.WriteLine("---------------------");
                        }
                        Console.ReadKey();
                        break;
                    case 10:
                        return;
                    default:
                        Console.WriteLine("Нет такого меню!");
                        Console.ReadKey();
                        return;
                }
               
            }
        }
    }
}
