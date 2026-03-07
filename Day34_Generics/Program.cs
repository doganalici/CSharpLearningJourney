using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day34_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kutu<int> sayiKutusu = new Kutu<int>();
            sayiKutusu.Deger = 10;

            Kutu<string> yaziKutusu = new Kutu<string>();
            yaziKutusu.Deger = "Merhaba";

            Console.WriteLine(sayiKutusu.Deger);
            Console.WriteLine(yaziKutusu.Deger);
        }
    }
}
