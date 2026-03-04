using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci lise = new LiseOgrencisi(1, "Ahmet", "Yılmaz", "Sayısal");
            Ogrenci uni = new UniversiteOgrencisi(2, "Mehmet", "Demir", "Bilgisayar Mühendisliği");

            lise.BilgileriYazdir();
            uni.BilgileriYazdir();
        }
    }
}
