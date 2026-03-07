using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32_Abstraction
{
    public class LiseOgrencisi : Ogrenci
    {
        public string Alan { get; set; }
        public LiseOgrencisi(int id, string ad, string soyad, string alan) : base(id, ad, soyad)
        {
            Alan = alan;
        }
        public override void BilgileriYazdir()
        {
            Console.WriteLine($"{Id} - {Ad} {Soyad} - Alan: {Alan}");
        }
    }
}
