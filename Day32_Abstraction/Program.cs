using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            ogrenciler.Add(new LiseOgrencisi(1, "Ahmet", "Yılmaz", "Sayısal"));
            ogrenciler.Add(new UniversiteOgrencisi(2, "Ayşe", "Kara", "Bilgisayar Mühendisliği"));


            foreach (var ogrenci in ogrenciler)
            {
                ogrenci.BilgileriYazdir();
            }
        }
    }
}
