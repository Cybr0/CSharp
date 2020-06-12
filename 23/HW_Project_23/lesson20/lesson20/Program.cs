using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson20
{
    class Worker
    {
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }
    }

    class Book
    {
        public string name { get; set; }
        public string publisher { get; set; }
        public string autor { get; set; }
        public double price { get; set; }
        public DateTime year { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Deferred Execution
            Console.WriteLine("------Deferred Execution--------");
            int[] arr = {1,2,4,55,3,4,6,10,50};
            IEnumerable<int> result = (from i in arr
                                       where i < 10 && i > 2
                                       select i);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            arr[3] = 8;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Class ion array
            Worker[] w_arr =
            {
                new Worker{ name="John Doe", age=30, salary=1000},
                new Worker{ name="Jane Doe", age=20, salary=8000},
                new Worker{ name="Some gay", age=25, salary=1500},
                new Worker{ name="hard Worker", age=28, salary=1800},
                new Worker{ name="top manager", age=40, salary=2000}
            };

            var workers = from w in w_arr
                          where w.salary > 1500
                          select w;
            foreach (var item in workers)
            {
                Console.WriteLine($"name:{item.name}; age:{item.age};salary:{item.salary}");
                //Console.WriteLine($"name:{item};");
            }
            #endregion

            #region Immediate Execution
            Console.WriteLine("------Immediate Execution--------");
            int[] arr1 = { 1, 2, 4, 55, 3, 4, 6, 10, 50 };
            int[] result1 = (from i in arr1
                                       where i < 10 && i > 2
                                       select i).ToArray<int>();

            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            arr1[3] = 8;
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Deferred Execution Exceptions
            Console.WriteLine("------Deferred Execution Exeptions--------");
            string [] str_arr = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
                            "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)" };
            var str_result = (from value in str_arr
                              where value.StartsWith("A")
                              select value);
            try
            {
                foreach (var item in str_result)
                {
                    Console.WriteLine(item);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            #endregion

            #region ordering ...
            Console.WriteLine("------Orderby--------");
            string[] str_data = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Chrysler", "Dodge", "BMW",
                            "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)" };
            var data_result = (from value in str_data
                               where value.Contains("a")
                               orderby value descending
                               select value);
            try
            {
                foreach (var item in data_result.Reverse())
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine($"count:{data_result.Count()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            #endregion

            #region Concat distinct except
            Console.WriteLine("------Concat distinct except--------");
            Console.WriteLine("------Concat --------");
            string[] str_data_a = { "Nissan", "Aston Martin", "Chevrolet", "Alfa Romeo", "Bentley", "Жигули :)" };
            string[] str_data_b = { "Alfa Romeo", "Chrysler", "Dodge", "BMW",
                            "Ferrari", "Audi", "Bentley", "Ford", "Lexus", "Mercedes", "Toyota", "Volvo", "Subaru", "Жигули :)" };
            var q_result = (from value in str_data_a
                            orderby value
                            select value).Concat(from value in str_data_b
                                                    orderby value
                                                    select value);

            foreach (var item in q_result)
            {
                Console.WriteLine(item);
            }

            var q_result_except = (from value in str_data_b
                            orderby value
                            select value).Except(from value in str_data_a
                                                 select value);
            Console.WriteLine("------except--------");
            foreach (var item in q_result_except)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------distinct --------");
            foreach (var item in q_result.Distinct())
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Agregate
            Console.WriteLine("------Max Min Sum Average Count --------");
            int[] data_arr_1 = { 1, 2, 4, 55, 3, 4, 6, 10, 50 };
            IEnumerable<int> result_data_array = (from i in arr select i);

            Console.WriteLine($"Sum():{result_data_array.Sum()}");
            Console.WriteLine($"Max():{result_data_array.Max()}");
            Console.WriteLine($"Min():{result_data_array.Min()}");
            Console.WriteLine($"Average():{result_data_array.Average()}");
            Console.WriteLine($"Count():{result_data_array.Count()}");
            #endregion

            #region anonimus types
            Console.WriteLine("------ anonimus types --------");
            List<Book> books = new List<Book>{
                new Book {name="Harry Potter", autor="J.K. Rowling", publisher="Press", price = 25, year=new DateTime(2018,1,1) },
                new Book {name="C++", autor="B. Straustrup", publisher="Prinston", price = 75, year=new DateTime(2018,1,1) },
                new Book {name="C#", autor="E. Troelsen", publisher="Some publisher", price = 100, year=new DateTime(2019,1,1) },
                new Book {name="SQL", autor="D Ritchi", publisher="Press", price = 60, year=new DateTime(2018,1,1) },
                new Book {name="MS SQL 2012", autor=" Forte", publisher="Microsoft press", price = 225, year=new DateTime(2011,1,1) }};

            var book_result = (from b in books
                              where b.name.StartsWith("C")
                              select new { b.name, b.autor }).ToArray();

            foreach (var book_item in book_result)
            {
                Console.WriteLine($"n:{book_item.name}, a:{book_item.autor}");
            }
            #endregion
        }
    }
}
