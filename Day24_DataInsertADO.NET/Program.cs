using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24_DataInsertADO.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
                "Server=DESKTOP-1BH7EFE\\MSSQLSERVER01;Database=TestDb;Trusted_Connection=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query =
                        "INSERT INTO Ogrenciler (Ad, Soyad) VALUES (@ad, @soyad)";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@ad", "Ali");
                    command.Parameters.AddWithValue("@soyad", "Kaya");

                    int sonuc = command.ExecuteNonQuery();

                    if (sonuc > 0)
                        Console.WriteLine("Kayıt başarıyla eklendi.");
                    else
                        Console.WriteLine("Kayıt eklenemedi.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
        }
    }
}
