using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Ahmet";
            ogrenci1.Soyad = "Yılmaz";
            ogrenci1.Yas = 25;
            ogrenci1.BilgileriYazdir();
            Console.WriteLine("\n------------------------------\n");

            Ogrenci ogrenci2 = new Ogrenci() { Ad = "Mehmet", Soyad = "Demir", Yas = -5 };

            ogrenci2.BilgileriYazdir();

        }
    }
}
