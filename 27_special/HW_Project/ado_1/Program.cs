using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ado_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=ShopDB; Integrated Security=True";
            SqlConnection connection = new SqlConnection(conStr);

            try
            {
                connection.Open();
                Console.WriteLine(connection.State);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine(connection.State);
            }
        }
    }
}
