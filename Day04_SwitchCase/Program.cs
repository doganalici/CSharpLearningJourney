using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t ------ GÜN HESAPLAMA ------\n");
            Console.Write("1-7 arasında bir sayı giriniz\n1 = Pazartesi\n2 = Salı\n3 = Çarşamba\n4 = Perşembe\n5 = Cuma\n6 = Cumartesi\n7 = Pazar\n\nSeçiminiz : ");
            int gun = Convert.ToInt32(Console.ReadLine());

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş!");
                    break;
            }

            Console.WriteLine("\n-------------------------\n\n");
            Console.WriteLine("\t ------ BASİT HESAP MAKİNESİ ------\n");

            Console.Write("1. sayıyı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nYapmak istediğiniz işlemi seçiniz\n1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme\nSeçiminiz : ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    int toplam = sayi1 + sayi2;
                    Console.WriteLine($"\n{sayi1} + {sayi2} = {toplam}");
                    break;
                case 2:
                    int fark = sayi1 - sayi2;
                    Console.WriteLine($"\n{sayi1} - {sayi2} = {fark}");
                    break;
                case 3:
                    int carpim = sayi1 * sayi2;
                    Console.WriteLine($"\n{sayi1} * {sayi2} = {carpim}");
                    break;
                case 4:
                    if (sayi2 != 0)
                    {
                        double bolum = (double)sayi1 / sayi2;
                        Console.WriteLine($"\n{sayi1} / {sayi2} = {bolum}");
                    }
                    else
                    {
                        Console.WriteLine("Sıfıra bölme hatası");
                    }
                    break;
                default:
                    Console.WriteLine("HATALI İŞLEM SEÇİMİ!");
                    break;
            }




            Console.WriteLine("\n-------------------------\n\n");
            Console.WriteLine("\t ------ NOT SİSTEMİ (HARF KARŞILIĞI) ------\n");
            Console.Write("Notunuzu giriniz (0-100) : ");
            int not = Convert.ToInt32(Console.ReadLine());

            switch (not / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("AA");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("BB");
                    break;
                case 6:
                case 5:
                    Console.WriteLine("CC");
                    break;
                default:
                    Console.WriteLine("FF");
                    break;
            }
        }
    }
}
