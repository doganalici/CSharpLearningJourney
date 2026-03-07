using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33_Interface
{
    public class Fatura:IYazdir
    {
        public void Yazdir()
        {
            Console.WriteLine("Fatura yazdırıldı.");
        }
    }
}
