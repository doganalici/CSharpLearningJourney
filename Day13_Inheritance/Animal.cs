using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Inheritance
{
    public class Animal
    {
        public string Ad { get; set; }
        public int Yas { get; set; }

        public void BilgilerYazdir()
        {
            Console.WriteLine($"Ad : {Ad}\n" +
                $"Yaş : {Yas}");
        }
    }
}
