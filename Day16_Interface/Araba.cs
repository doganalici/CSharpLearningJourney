using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Interface
{
    internal class Araba : IArac
    {
        public void Calistir()
        {
            Console.WriteLine("Araç çalıştırıldı.");
        }

        public void Durdur()
        {
            Console.WriteLine("Araç durduruldu.");
        }
    }
}
