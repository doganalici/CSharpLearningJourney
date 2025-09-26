using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Polymorphism
{
    public class Hayvan
    {
        public virtual void SesCikar()
        {
            Console.WriteLine("Hayvan ses çıkarıyor...");
            Console.WriteLine("\n----------------------------\n");
        } 
    }
}
