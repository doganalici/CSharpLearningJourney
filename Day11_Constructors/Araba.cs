using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Constructors
{
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Renk { get; set; }


        //1-Parametresiz Constructor (varsayılan değerler)
        public Araba()
        {
            Marka = "Bilinmiyor";
            Model = "Bilinmiyor";
            Yil = 0;
            Renk = "Bilinmiyor";
        }

        //2-Parametreli Constructor
        public Araba(string marka, string model, int yil, string renk)
        {
            Marka = marka;
            Model = model;
            Yil = yil;
            Renk = renk;
        }
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Marka : {Marka}\n" +
                $"Model : {Model}\n" +
                $"Yıl : {Yil}\n" +
                $"Renk : {Renk}");
        }
    }
}
