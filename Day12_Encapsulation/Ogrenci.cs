using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Encapsulation
{
    public class Ogrenci
    {
        private int yas;
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas
        {
            get { return yas; }
            set
            {
                if (value < 0 || value > 110)
                {
                    Console.WriteLine("Geçersiz yaş girildi!");
                }
                else
                {
                    yas = value;
                }
            }
        }
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Ad : {Ad}\n" +
                $"Soyad : {Soyad}\n" +
                $"Yaş : {yas}");
        }
    }
}
