using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18_GenericsAndCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List();

            //Dictionary();

            //QueueFIFO();

            Stack<string> kitaplar = new Stack<string>();
            kitaplar.Push("Suç ve Ceza");
            kitaplar.Push("Sefiller");
            kitaplar.Push("Kürk Mantolu Madonna");
            kitaplar.Push("1984");

            Console.WriteLine("Kitap Yığını : ");
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap);
            }

            Console.WriteLine($"\nEn üstteki kitap : {kitaplar.Peek()}");
            Console.WriteLine($"\n{kitaplar.Pop()} raftan alındı");
            Console.WriteLine("\nGüncel Kitap Yığını : ");
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap);
            }

        }

        private static void QueueFIFO()
        {
            Queue<string> musteriler = new Queue<string>();
            musteriler.Enqueue("Ahmet");
            musteriler.Enqueue("Mehmet");
            musteriler.Enqueue("Ayşe");
            musteriler.Enqueue("Fatma");

            Console.WriteLine("Müşteri Kuyruğu : ");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri);
            }

            Console.WriteLine($"\nSıradaki müşteri : {musteriler.Peek()}");
            Console.WriteLine($"\n{musteriler.Dequeue()} isimli müşterinin işlemi tamamlandı.");

            Console.WriteLine("\nGüncel Kuyruk : ");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri);
            }
        }

        private static void Dictionary()
        {
            Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
            ogrenciler.Add(101, "Ahmet Yılmaz");
            ogrenciler.Add(102, "Mehmet Demir");
            ogrenciler.Add(103, "Ayşe Kara");

            Console.WriteLine("Öğrenci Listesi : ");
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine($"Öğrenci numarası : {ogrenci.Key}\n" +
                    $"Öğrenci Ad Soyad : {ogrenci.Value}\n");
            }

            Console.WriteLine("\n102 numaralı öğrenciyi siliyorum...");
            ogrenciler.Remove(102);
            Console.WriteLine("Güncel Öğrenci Listesi : ");
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine($"Öğrenci numarası : {ogrenci.Key}\n" +
                    $"Öğrenci Ad Soyad : {ogrenci.Value}\n");
            }
        }

        private static void List()
        {
            List<string> isimler = new List<string>();
            isimler.Add("Ahmet");
            isimler.Add("Mehmet");
            isimler.Add("Ayşe");
            isimler.Add("Fatma");

            Console.WriteLine("Liste Elemanları : ");
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine($"\nEleman sayısı : {isimler.Count}");

            isimler.Remove("Mehmet");
            Console.WriteLine("\nMehmet silindikten sonra : ");
            foreach (var isim in isimler)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
