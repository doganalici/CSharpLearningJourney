using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29_EncapsulationAndProperties
{
    public class Ogrenci
    {
        private string _ad;
        private string _soyad;
        private int _yas;

        public int Id { get; set; }
        public string Ad
        {
            get { return _ad; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _ad = value;
                }
                else
                {
                    Console.WriteLine("Ad boş olamaz");
                }
            }
        }
        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }

        public int Yas
        {
            get { return _yas; }
            set
            {
                if (value > 0)
                {
                    _yas = value;
                }
                else
                {
                    Console.WriteLine("Yaş sıfırdan büyük olmalıdır");
                }
            }
        }

        public string TamAd
        {
            get { return $"{Ad} {Soyad}"; }
        }

        public Ogrenci(int id,string ad,string soyad,int yas)
        {
            Id=id;
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine($"{Id} - {TamAd} - {Yas}");
        }
    }
}
