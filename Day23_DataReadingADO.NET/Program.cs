using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_DataReadingADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-1BH7EFE\\MSSQLSERVER01;Database=TestDb;Trusted_Connection=True";


            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "SELECT Id, Ad, Soyad FROM Ogrenciler";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["Id"]} - {reader["Ad"]} {reader["Soyad"]}");
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }
    }
}
