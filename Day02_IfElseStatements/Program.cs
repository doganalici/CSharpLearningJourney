using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_IfElseStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Pozitif/Negatif Sayı Kontrolü *** ");
            Console.Write("Bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine($"{sayi} sayısı pozitiftir");
            }
            else if (sayi < 0)
            {
                Console.WriteLine($"{sayi} sayısı negatiftir");
            }
            else
            {
                Console.WriteLine("Sayı sıfırdır");
            }

            Console.WriteLine("\n\n\n*** Not Hesaplama *** ");
            Console.Write("0-100 aralığında bir not giriniz : ");
            int not = Convert.ToInt32(Console.ReadLine());
            if (not >= 90 && not <= 100)
            {
                Console.WriteLine("AA");
            }
            else if (not >= 70 && not <= 89)
            {
                Console.WriteLine("BB");
            }
            else if (not >= 50 && not <= 69)
            {
                Console.WriteLine("CC");
            }
            else if (not >= 0 && not <= 49)
            {
                Console.WriteLine("FF");
            }
            else
            {
                Console.WriteLine("Hatalı not girişi!");
            }


            Console.WriteLine("\n\n\n*** Yaş Kontrolü *** ");
            Console.Write("Yaşınızı giriniz : ");
            int yas = Convert.ToInt32(Console.ReadLine());
            if (yas < 18)
            {
                Console.WriteLine("Ehliyet alamazsınız!");
            }
            else
            {
                Console.WriteLine("Ehliyet alabilirsiniz");
            }

            Console.WriteLine("\n\n\n*** Login Kontrolü *** ");
            Console.Write("Kullancı adı : ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifre : ");
            string sifre = Console.ReadLine();
            if (kullaniciAdi == "dogan" && sifre == "1234")
            {
                Console.WriteLine("Giriş başarılı");
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı adı ya da şifre!");
            }
        }
    }
}
