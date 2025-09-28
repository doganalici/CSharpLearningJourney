using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Interface
{
    internal class Motosiklet : IArac
    {
        public void Calistir()
        {
            Console.WriteLine("Motosiklet çalıştırıldı.");
        }

        public void Durdur()
        {
            Console.WriteLine("Motosiklet durduruldu.");
        }
    }
}
