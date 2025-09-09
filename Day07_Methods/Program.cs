using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Selamla();
            Console.WriteLine("****************************");
            Topla(3, 5);
            Console.WriteLine("****************************");
            int sonuc = Carp(3, 5);
            Console.WriteLine(sonuc);
            Console.WriteLine("****************************");
            int kare = Kare(4);
            Console.WriteLine(kare);

        }
        //Parametresiz metot
        public static void Selamla()
        {
            Console.WriteLine("Merhaba! C# öğrenmeye devam");
        }

        //Parametreli metot
        public static void Topla(int a, int b)
        {
            int sonuc = a + b;
            Console.WriteLine($"{a} + {b} = {sonuc}");
        }

        //Değer döndüren metot
        public static int Carp(int x, int y)
        {
            return x * y;
        }

        public static int Kare(int sayi)
        {
            return sayi * sayi;
        }

    }
}
