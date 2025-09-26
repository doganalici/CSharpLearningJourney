using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Polymorphism
{
    public class Kopek : Hayvan
    {
        public override void SesCikar()
        {
            Console.WriteLine("Köpek havlıyor");
            Console.WriteLine("\n----------------------------\n");

        }
    }
}
