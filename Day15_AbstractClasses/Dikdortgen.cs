using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_AbstractClasses
{
    public class Dikdortgen : Sekil
    {

        public double KisaKenar { get; set; }
        public double UzunKenar { get; set; }

        public Dikdortgen(double kisa, double uzun)
        {
            Ad = "Dikdörtgen";
            KisaKenar = kisa;
            UzunKenar = uzun;
        }
        public override double AlanHesapla() => KisaKenar * UzunKenar;
        public override double CevreHesapla() => 2 * (KisaKenar + UzunKenar);

    }
}
