using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31_Polymorphism
{
    public class LiseOgrencisi : Ogrenci
    {
        public string Alan { get; set; }
        public LiseOgrencisi(int id, string ad, string soyad, string alan) : base(id, ad, soyad)
        {
            Alan = alan;
        }
        public override void BilgiYazdir()
        {
            Console.WriteLine($"{Id} - {Ad} {Soyad} - {Alan}");
        }
    }
}
