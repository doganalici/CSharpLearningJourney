using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day33_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IYazdir> liste = new List<IYazdir>();

            liste.Add(new Rapor());
            liste.Add(new Fatura());

            foreach (var item in liste)
            {
                item.Yazdir();
            }
        }
    }
}
