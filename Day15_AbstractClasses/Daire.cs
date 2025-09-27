using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_AbstractClasses
{
    public class Daire : Sekil
    {
        public double Yaricap { get; set; }
        public Daire(double r)
        {
            Ad = "Daire";
            Yaricap = r;
        }
        public override double AlanHesapla() => Math.PI * Yaricap * Yaricap;


        public override double CevreHesapla() => 2 * Math.PI * Yaricap;
    }
}
