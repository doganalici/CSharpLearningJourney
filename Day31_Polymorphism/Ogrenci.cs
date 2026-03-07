using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day31_Polymorphism
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Ogrenci(int id,string ad,string soyad)
        {
            Id= id;
            Ad= ad;
            Soyad= soyad;
        }
        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"{Id} - {Ad} {Soyad}");
        }
    }
}
