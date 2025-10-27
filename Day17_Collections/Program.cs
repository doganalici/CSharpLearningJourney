using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenciler = new Dictionary<int, string>();

            ogrenciler.Add(101, "Ahmet Yılmaz");
            ogrenciler.Add(102, "Mehmet Demir");
            ogrenciler.Add(103, "Ayşe Kara");

            bool devam = true;

            while (devam)
            {
                Console.WriteLine("\n*** ÖĞRENCİ YÖNETİM SİSTEMİ ***");
                Console.WriteLine("1- Öğrenci Listele");
                Console.WriteLine("2- Öğrenci Ekle");
                Console.WriteLine("3- Öğrenci Güncelle");
                Console.WriteLine("4- Öğrenci Sil");
                Console.WriteLine("5- Çıkış");

                Console.Write("Seçiminiz : ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("\n ---Öğrenci Listesi ---");
                        foreach (var ogrenci in ogrenciler)
                        {
                            Console.WriteLine($"Öğrenci numarası : {ogrenci.Key}\n" +
                                $"Öğrenci Ad Soyad : {ogrenci.Value}");
                            Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
                        }
                        break;
                    case 2:
                        Console.Write("\nYeni öğrenci numarası : ");
                        int yeniNo = Convert.ToInt32(Console.ReadLine());
                        if (ogrenciler.ContainsKey(yeniNo))
                        {
                            Console.WriteLine("Bu numara sistemde kayıtlı");
                        }
                        else
                        {
                            Console.Write("Öğrenci adı soyadı :");
                            string yeniAd = Console.ReadLine();
                            ogrenciler.Add(yeniNo, yeniAd);
                            Console.WriteLine("Öğrenci Eklendi");
                        }
                        break;
                    case 3:
                        Console.Write("\nGüncellenecek öğrenci numarası : ");
                        int guncelNo = Convert.ToInt32(Console.ReadLine());
                        if (ogrenciler.ContainsKey(guncelNo))
                        {
                            Console.Write("Yeni Ad Soyad : ");
                            ogrenciler[guncelNo] = Console.ReadLine();
                            Console.WriteLine("Bilgiler Güncellendi");
                        }
                        else
                        {
                            Console.WriteLine("Öğrenci bulunamadı");
                        }
                        break;
                    case 4:
                        Console.Write("Silinecek öğrenci numarası : ");
                        int silNo = Convert.ToInt32(Console.ReadLine());
                        if (ogrenciler.Remove(silNo))
                        {
                            Console.WriteLine("Öğrenci silinmiştir");
                        }
                        else
                        {
                            Console.WriteLine("Öğrenci bulunamadı");
                        }
                        break;
                    case 5:
                        devam = false;
                        break;
                    default:
                        Console.WriteLine("Hatalı tuşlama");
                        break;
                }
            }
            Console.WriteLine("Program sonlandı. İyi günler...");
        }
    }
}
