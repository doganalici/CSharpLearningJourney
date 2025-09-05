using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** For Döngüsü - 1'den 10'a kadar sayılar ***");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n*** While Döngüsü - 1'den 5'e kadar sayılar ***");
            int j = 1;
            while (j <= 5)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("\n*** Do - While Döngüsü - 1'den 3'e kadar sayılar ***");
            int k = 1;
            do
            {
                Console.WriteLine("k : " + k);
                k++;
            } while (k <= 3);

            Console.WriteLine("\n*** For Döngüsü - 0'dan 100'e kadar çift sayıların toplamı ***");
            int sayac1 = 0;
            for (int x = 0; x <= 100; x += 2)
            {
                sayac1 += x;
            }
            Console.WriteLine($"Toplam : {sayac1}");

            Console.WriteLine("\n*** While Döngüsü - Faktöriyel Hesabı ***");
            int faktoriyel = 1;
            int y = 1;
            Console.Write("Faktörili hesaplanacak sayı : ");
            int deger = Convert.ToInt32(Console.ReadLine());
            while (y <= deger)
            {
                faktoriyel *= y;
                y++;
            }
            Console.WriteLine($"{deger}! = {faktoriyel}");


        }
    }
}
