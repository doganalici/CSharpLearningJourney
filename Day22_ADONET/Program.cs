using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22_ADONET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-1BH7EFE\\MSSQLSERVER01;Database=TestDb;Trusted_Connection=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Veritabanı bağlantısı başarılı");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bağlantı hatası X");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
                Console.WriteLine("Bağlantı kapatıldı.");
            }
        }
    }
}
