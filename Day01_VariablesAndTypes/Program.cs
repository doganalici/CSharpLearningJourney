using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01_VariablesAndTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yas = 27;
            double maas = 32500.50;
            string ad = "Doğan";
            bool yazilimciMi = true;
            string enSevdigiYemek = "Patlican";
            double boy = 1.92;
            bool kodlamayiSeviyorMu = true;

            Console.WriteLine($"Ad : {ad}\nYaş : {yas}\nMaaş : {maas}\nYazılımcı mı? : {yazilimciMi}\nEn sevdiği yemek : {enSevdigiYemek}\nBoy : {boy}\nKodlamayı seviyor mu? : {kodlamayiSeviyorMu}\n\n\n ");

            Console.Write("Adınızı yazınız : ");
            string kullaniciAdi = Console.ReadLine();

            Console.Write("Yaşınızı giriniz : ");
            int kullaniciYas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n\nKullanıcının adı : {kullaniciAdi}\nKullanıcının yaşı : {kullaniciYas}");
        }
    }
}
