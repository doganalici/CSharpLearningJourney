using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya" };
            Console.WriteLine("\t**** ŞEHİRLER DİZİSİ ****\n");
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine($"{i + 1}.şehir = {sehirler[i]}");
            }

            Console.WriteLine("-----------------------------------------");

            string[] ogrenciler = new string[5]; //Önce boş bir dizi oluşturduk
            Console.WriteLine("\t **** ÖĞRENCİ KAYIT ****\n");
            for (int i = 0; i < ogrenciler.Length; i++) //for döngüsü ile oluşturduğumuz dizinin elemanlarını kullanıcıdan girmesini istedik
            {
                Console.Write($"{i + 1}.öğrencinin adını giriniz : ");
                ogrenciler[i] = Console.ReadLine();
            }

            Console.WriteLine("\n\t **** ÖĞRENCİ LİSTESİ ****\n");
            for (int i = 0; i < ogrenciler.Length; i++) //kullanıcı tarafından girilen değerlerin for döngüsü ile çekilmesi sağlandı
            {
                Console.WriteLine($"{i + 1}.öğrenci : {ogrenciler[i]}");
            }

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("\n\t **** DİZİ ORTALAMASI ****\n");
            int[] sayilar = { 10, 20, 30, 40, 50 }; // önce dizimizi tanımladık
            int toplam = 0; //toplamı bir değişene atayabilmek için int tipinde bir değer verdik ve ilk değeri 0 olarak tanımladık
            for (int i = 0; i < sayilar.Length; i++) //for döngüsü ile bütün diziyi dönderdik ve toplama bu dizideki sayıların hepsini toplayarak eşitledik
            {
                toplam += sayilar[i];
            }
            double ortalama = (double)toplam / sayilar.Length; //ortalama double olabileceği için işlemimizi doubleye göre yaptık ve toplarım sayıların adetine bölerek ortalama değişkenine eşitledik
            Console.WriteLine($"Dizideki sayıların ortalaması : {ortalama}");

            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("\n\t **** KULLANICININ VERDİĞİ DEĞERDE DİZİ ORTALAMASI ****\n");
            Console.Write("Kaç adet sayı gireceksiniz : ");
            int adet = Convert.ToInt32(Console.ReadLine());
            int[] sayilar2 = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{i + 1}.sayı : ");
                sayilar2[i] = Convert.ToInt32(Console.ReadLine());
            }


            int toplam2 = 0;
            foreach (int sayi in sayilar2)
            {
                {
                    toplam2 += sayi;
                }
            }
            double ortalama2 = (double)toplam2 / sayilar2.Length;
            Console.WriteLine($"\n\n{adet} adet girilen sayının ortalaması : {ortalama2}");

            Console.WriteLine("-----------------------------------------");
        }
    }
}
