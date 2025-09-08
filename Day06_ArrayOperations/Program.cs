using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_ArrayOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t **** DİZİ İŞLEMLERİ (Min, Max, Sıralama) ****\n");
            Console.Write("Kaç adet sayı girilecek : ");
            int adet = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet];

            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{i + 1}.sayı : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            //En küçük ve en büyük sayıyı bulma
            int min = sayilar[0];
            int max = sayilar[0];

            foreach (int sayi in sayilar)
            {
                if (sayi < min)
                {
                    min = sayi;
                }
                else if (sayi > max)
                {
                    max = sayi;
                }
            }
            Console.WriteLine($"\nDizideki en küçük sayı : {min}");
            Console.WriteLine($"Dizideki en büyük sayı : {max}\n\n");

            //Diziyi sıralama
            Console.WriteLine("\nSıralı dizi (küçükten büyüğe):");
            Array.Sort(sayilar);
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("\nSıralı dizi (büyükten küçüğe):");
            Array.Reverse(sayilar);
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
