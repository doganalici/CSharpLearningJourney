using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            Araba araba2 = new Araba();
            araba2.Marka = "Volkswagen";
            araba2.Model = "Passat";
            araba2.Yil = 2011;
            araba2.Renk = "Siyah";

            Araba araba3 = new Araba("BMW", "320i", 2022, "Beyaz");

            Console.WriteLine("1.Arabanın Özellikleri\n");
            araba1.BilgileriYazdir();
            Console.WriteLine("\n***************************\n");
            Console.WriteLine("2.Arabanın Özellikleri\n");
            araba2.BilgileriYazdir();
            Console.WriteLine("\n***************************\n");
            Console.WriteLine("3.Arabanın Özellikleri\n");
            araba3.BilgileriYazdir();


        }
    }
}
