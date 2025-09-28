using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IArac> araclar = new List<IArac>() { new Araba(), new Motosiklet()};
            foreach (var arac in araclar)
            {
                arac.Calistir();
                arac.Durdur();
                Console.WriteLine("------------------------");
            }
        }
    }
}
