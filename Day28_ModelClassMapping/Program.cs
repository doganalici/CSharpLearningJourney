using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day28_ModelClassMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-1BH7EFE\\MSSQLSERVER01;Database=TestDb;Trusted_Connection=True";

            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id,Ad,Soyad FROM Ogrenciler";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = (int)reader["Id"];
                        string ad = reader["Ad"].ToString();
                        string soyad = reader["Soyad"].ToString();

                        Ogrenci ogrenci = new Ogrenci(id, ad, soyad);
                        ogrenciler.Add(ogrenci);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hatalı tuşlama yaptınız : {ex.Message}");
                }
            }
            foreach (var ogrenci in ogrenciler)
            {
                ogrenci.BilgileriYazdir();
            }
        }
    }
}
