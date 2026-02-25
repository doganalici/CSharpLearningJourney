using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day25_UpdateDeleteADO.NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-1BH7EFE\\MSSQLSERVER01;Database=TestDb;Trusted_Connection=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Ogrenciler SET Ad=@ad WHERE Id=@id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ad", "Veli");
                command.Parameters.AddWithValue("@id", 1);

                try
                {
                    connection.Open();
                    int sonuc = command.ExecuteNonQuery();

                    if (sonuc > 0)
                    {
                        Console.WriteLine("[BAŞARILI] Kayıt güncellendi");
                    }
                    else
                    {
                        Console.WriteLine("[BAŞARISIZ] Kayıt bulunamadı");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[HATA] Bir sorun oluştu : {ex.Message}");
                }
            }

            Console.WriteLine("************************************");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Ogrenciler WHERE Id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", 1);

                try
                {
                    connection.Open();
                    int sonuc= command.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        Console.WriteLine("[BAŞARILI] Kayıt silindi");
                    }
                    else
                    {
                        Console.WriteLine("[BAŞARISIZ] Kayıt bulunamadı");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[HATA] Bir sorun oluştu : {ex.Message}");
                }
            }
        }
    }
}
