using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_ClassesAndObjects
{
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Renk { get; set; }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Marka : {Marka}\n" +
                $"Model : {Model}\n" +
                $"Yıl : {Yil}\n" +
                $"Renk : {Renk}");
        }
        public int YasiHesapla()
        {
            int yil=DateTime.Now.Year;
            return yil-Yil;
        }
    }
}
