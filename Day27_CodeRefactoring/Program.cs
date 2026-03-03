using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day27_CodeRefactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
    "Server=DESKTOP-1BH7EFE\\MSSQLSERVER01;Database=TestDb;Trusted_Connection=True";

            bool state = true;
            while (state)
            {
                Console.WriteLine("\n---- ÖĞRENCİ YÖNETİM SİSTEMİ ----\n");
                Console.WriteLine("1 - Listele");
                Console.WriteLine("2 - Ekle");
                Console.WriteLine("3 - Güncelle");
                Console.WriteLine("4 - Sil");
                Console.WriteLine("5 - Çıkış");

                Console.Write("Seçiminiz : ");
                int secim;
                while (!int.TryParse(Console.ReadLine(), out secim))
                {
                    Console.WriteLine("Hatalı tuşlama yaptınız!");
                }

                switch (secim)
                {
                    case 1:
                        Console.Clear();
                        Listele(connectionString);
                        break;

                    case 2:
                        Console.Clear();
                        Ekle(connectionString);
                        break;

                    case 3:
                        Console.Clear();
                        Guncelle(connectionString);
                        break;

                    case 4:
                        Console.Clear();
                        Sil(connectionString);
                        break;

                    case 5:
                        Console.Clear();
                        state = false;
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }
            }
        }

        static void Listele(string connectionString)
        {
            using (SqlConnection connection = GetConnection(connectionString))
            {
                try
                {
                  
                    string query = "SELECT Id, Ad, Soyad FROM Ogrenciler";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("---- ÖĞRENCİ LİSTESİ ----");
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("Kayıt bulunamadı.");
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader["Id"]} - {reader["Ad"]} {reader["Soyad"]}");
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
        }

        static void Ekle(string connectionString)
        {
            Console.Write("Ad : ");
            string ad = Console.ReadLine()?.Trim();

            Console.Write("Soyad : ");
            string soyad = Console.ReadLine()?.Trim();

            using (SqlConnection connection = GetConnection(connectionString))
            {
                try
                {

                    string query = "INSERT INTO Ogrenciler (Ad,Soyad) VALUES (@ad,@soyad)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ad", ad);
                    command.Parameters.AddWithValue("@soyad", soyad);

                    int sonuc = command.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        Console.WriteLine("Kayıt başarıyla eklendi");
                    }
                    else
                    {
                        Console.WriteLine("Kayıt eklenemedi");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
        }

        static void Guncelle(string connectionString)
        {
            Console.Write("Güncelenecek Id : ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Hatalı tuşlama yaptınız!");
            }

            Console.Write("Yeni Ad : ");
            string ad = Console.ReadLine()?.Trim();

            Console.Write("Yeni Soyad : ");
            string soyad = Console.ReadLine()?.Trim();

            using (SqlConnection connection = GetConnection(connectionString))
            {
                try
                {
                    string query = "UPDATE Ogrenciler SET Ad=@ad, Soyad=@soyad WHERE Id=@id";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ad", ad);
                    command.Parameters.AddWithValue("@soyad", soyad);
                    command.Parameters.AddWithValue("@id", id);

                    int sonuc = command.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        Console.WriteLine("Kayıt başarıyla güncellendi");
                    }
                    else
                    {
                        Console.WriteLine("Kayıt güncellenemedi");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
        }

        static void Sil(string connectionString)
        {
            Console.Write("Silinecek Id : ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Hatalı tuşlama yaptınız!");
            }
            using (SqlConnection connection = GetConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM Ogrenciler WHERE Id=@id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    int sonuc = command.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        Console.WriteLine("Kayıt silindi.");
                    }
                    else
                    {
                        Console.WriteLine("Kayıt bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
            }
        }

        static SqlConnection GetConnection(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
