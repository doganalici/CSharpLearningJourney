using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Inheritance
{
    public class Dog:Animal
    {
        public string Cins { get; set; }
        public void Havla()
        {
            Console.WriteLine($"Hav hav!");
        }
    }
}
