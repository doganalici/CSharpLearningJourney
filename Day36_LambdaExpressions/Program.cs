using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36_LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> topla = (a, b) => a + b;

            Console.WriteLine(topla(3, 4));



            Action<string> yazdir = mesaj => Console.WriteLine(mesaj);

            yazdir("Merhaba Lambda");


            Predicate<int> ciftMi = sayi => sayi % 2 == 0;

            Console.WriteLine(ciftMi(10));


            List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 6 };

            var ciftler = sayilar.Where(x => x % 2 == 0);

            foreach (var sayi in ciftler)
            {
                Console.WriteLine(sayi);


            }
        }
    }
}
