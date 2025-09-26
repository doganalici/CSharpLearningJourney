using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan kopek = new Kopek();
            Hayvan kedi = new Kedi();
            Hayvan kus = new Kus();

            List<Hayvan> hayvanlar = new List<Hayvan>() { kopek, kedi, kus };
            foreach (var hayvan in hayvanlar)
            {
                hayvan.SesCikar();
            }

        }
    }
}
