using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_ArraysAndMethods
{
    public class UseArray
    {
        public void DiziAl()
        {
            Console.Write("Kaç adet sayı gireceksiniz : ");
            int adet = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[adet];

            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{i + 1}.sayı : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"\nDizideki en büyük sayı : {MaxBul(sayilar)}");
            Console.WriteLine($"Dizideki en küçük sayı : {MinBul(sayilar)}");
        }
        public static int MaxBul(int[] dizi)
        {
            int max = dizi[0];
            foreach (int i in dizi)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }
        public static int MinBul(int[] dizi)
        {
            int min = dizi[0];
            foreach (int i in dizi)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
    }
}
