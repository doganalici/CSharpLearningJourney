using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_AbstractClasses
{
    public abstract class Sekil
    {
        public string Ad { get; set; }
        public abstract double AlanHesapla();
        public abstract double CevreHesapla();

        public void BilgileriYazdir()
        {
            Console.WriteLine($"Şekil adı : {Ad}\n" +
                $"Şekil alanı : {AlanHesapla()}\n" +
                $"Şekil çevresi : {CevreHesapla()}");
        }
    }
}
