using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29_EncapsulationAndProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci(1,"Ahmet","Yılmaz",20);
            ogrenci1.BilgileriYazdir();

            Console.WriteLine("---- Hatalı veri test ----");
            Ogrenci ogrenci2 = new Ogrenci(2,"","Kara",-5);
            ogrenci2.BilgileriYazdir();

        }
    }
}
