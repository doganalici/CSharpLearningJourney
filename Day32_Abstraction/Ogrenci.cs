using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day32_Abstraction
{
    public abstract class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public Ogrenci(int id, string ad, string soyad)
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;
        }
        public abstract void BilgileriYazdir();
    }
}
