using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog() { Ad = "Karabaş", Yas = 3 };
            dog.BilgilerYazdir();
            dog.Havla();

            Console.WriteLine("---------------------");

            Cat cat = new Cat();
            cat.Ad = "Pamuk";
            cat.Yas = 2;

            cat.BilgilerYazdir();
            cat.Miyavla();
        }
    }
}
