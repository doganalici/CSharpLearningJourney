using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.Marka = "Toyota";
            araba1.Model = "Corolla";
            araba1.Yil = 2020;
            araba1.Renk = "Beyaz";


            Araba araba2 = new Araba();
            araba2.Marka = "BMW";
            araba2.Model = "320i";
            araba2.Yil = 2022;
            araba2.Renk = "Siyah";

            araba1.BilgileriYazdir();
            Console.WriteLine($"Arabanın yaşı : {araba1.YasiHesapla()}");
            Console.WriteLine("\n*********************\n");
            araba2.BilgileriYazdir();
            Console.WriteLine($"Arabanın yaşı : {araba2.YasiHesapla()}");
        }
    }
}
