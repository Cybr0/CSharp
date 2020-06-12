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

namespace lesson22
{
    [Serializable]
    public class Book
    {
        public string name;
        public string publisher;
        public int pages;
        public string autor;
        [OnSerializing]
        public void on_serializing(StreamingContext context)
        {
            try
            {
                publisher = publisher.ToUpper();
                Console.WriteLine("on_serializing");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [OnDeserialized]
        public void on_deserialized(StreamingContext context)
        {
            try
            {
                publisher = publisher.ToLower();
                Console.WriteLine("on_deserialized");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }


        [NonSerialized]
        public int taked_count;

        public override string ToString()
        {
            return $"name:{name}\npublisher:{publisher}\n" +
                $"autor:{autor}\npages:{pages}\ntaked:{taked_count}\n";
        }
    }
    [Serializable]
    public class BakerBook : Book
    {
        public int recepies_count;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book my_book = new Book();
            my_book.name = "New book";
            my_book.publisher = "Press";
            my_book.autor = "Writer";
            my_book.pages = 300;
            my_book.taked_count = 30;
            //my_book.recepies_count = 100;
            #region 
            
            try
            {
                using (FileStream s_file = new FileStream("book.xml", FileMode.Create))
                {
                    SoapFormatter bf = new SoapFormatter();
                    bf.Serialize(s_file, my_book);
                }

                SoapFormatter bf_o = new SoapFormatter();
                using (FileStream d_file = new FileStream("book.xml", FileMode.Open))
                {
                    Book my_book_des = (Book)bf_o.Deserialize(d_file);
                    Console.WriteLine(my_book_des);
                }
                
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion
            #region 
            /*
            try
            {
                XmlSerializer x_ser = new XmlSerializer(typeof(BakerBook), new Type[] { typeof(Book) });
                using (FileStream fs = new FileStream("xml_file.xml", FileMode.Create))
                {
                    x_ser.Serialize(fs, my_book);
                }


                XmlSerializer d_ser = new XmlSerializer(typeof(BakerBook), new Type[] { typeof(Book) });
                using (FileStream fs = new FileStream("xml_file.xml", FileMode.Open))
                {
                    BakerBook bb = (BakerBook)x_ser.Deserialize(fs);
                    Console.WriteLine(bb);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
            #endregion

        }
    }
}
