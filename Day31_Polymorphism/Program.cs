using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            ogrenciler.Add(new LiseOgrencisi(1, "Ahmet", "Yılmaz", "Sayısal"));
            ogrenciler.Add(new UniversiteOgrencisi(2, "Ayşe", "Kara", "Bilgisayar Mühendisliği"));
            ogrenciler.Add(new LiseOgrencisi(3, "Mehmet", "Demir", "Eşit Ağırlık"));

            foreach (var ogrenci in ogrenciler)
            {
                ogrenci.BilgiYazdir();
            }
        }
    }
}
