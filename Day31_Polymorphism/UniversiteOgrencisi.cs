using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31_Polymorphism
{
    public class UniversiteOgrencisi : Ogrenci
    {

        public string Bolum { get; set; }
        public UniversiteOgrencisi(int id, string ad, string soyad,string bolum) : base(id, ad, soyad)
        {
            Bolum = bolum;
        }
        public override void BilgiYazdir()
        {
            Console.WriteLine($"{Id} - {Ad} {Soyad} - {Bolum}");
        }
    }
}
