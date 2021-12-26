using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlDataReader read = null;
            SqlDataReader read1 = null;
            string sql,sql1;

            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=komis; User ID=zuzanna; Password=zuzanna");
            SqlConnection conn1 = new SqlConnection("Data Source=localhost; Initial Catalog=komis; User ID=zuzanna; Password=zuzanna");
            try
            {
                conn.Open();
                Console.WriteLine("Prawidłowe połaczenie z bazą danych\n");
                sql = "select * from [user]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                read = cmd.ExecuteReader();
                while (read.Read())
                {
                    Console.WriteLine("ID:" + read[3] + " Miasto:" + read[2] + " Imię:" + read[0]);
                }
                Console.WriteLine("Prawidłowe połaczenie z bazą danych\n");
                sql1 = "select * from [car]";
                SqlCommand cmdd = new SqlCommand(sql1, conn1);
                read1 = cmdd.ExecuteReader();
                while (read1.Read())
                {
                    Console.WriteLine("ID:" + read1[3]);
                }


            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }finally
            {
                if(conn !=null)
                {
                    conn.Close();
                }
            }
            Console.ReadKey();

        }
    }
}
