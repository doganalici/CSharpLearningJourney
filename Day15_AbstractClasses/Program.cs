using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sekil sekil1 = new Dikdortgen(5, 10);
            Sekil sekil2 = new Daire(7);

            sekil1.BilgileriYazdir();
            Console.WriteLine("\n--------------------------------\n");
            sekil2.BilgileriYazdir();

        }
    }
}
