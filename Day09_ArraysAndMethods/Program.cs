using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_ArraysAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 5, 8, 12, 3, 7 };
            DiziYazdir(sayilar);
            Console.WriteLine("\n*******************************\n");
            int toplam = DiziToplam(sayilar);
            Console.WriteLine($"Dizinin toplamı : {toplam}");
            Console.WriteLine("\n**************************\n");
            double ortalama = DiziOrtalama(sayilar);
            Console.WriteLine($"Dizinin ortalaması : {ortalama}");
            Console.WriteLine("\n*******************************\n");

            UseArray useArray = new UseArray();
            useArray.DiziAl();
            Console.WriteLine("\n*******************************\n");

        }

        public static void DiziYazdir(int[] dizi)
        {
            Console.WriteLine("Dizinin elemanları;");
            foreach (int i in dizi)
            {
                Console.Write(i + " ");
            }
        }

        public static int DiziToplam(int[] dizi)
        {
            int toplam = 0;
            foreach (int i in dizi)
            {
                toplam += i;
            }
            return toplam;
        }

        public static double DiziOrtalama(int[] dizi)
        {
            return (double)DiziToplam(dizi) / dizi.Length;
        }

    }
}
