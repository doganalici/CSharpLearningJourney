using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_QueueStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> musteriler = new Queue<string>();

            musteriler.Enqueue("Ahmet");
            musteriler.Enqueue("Mehmet");
            musteriler.Enqueue("Ayşe");
            musteriler.Enqueue("Fatma");

            Console.WriteLine("Müşteri kuyruğu : ");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri);
            }

            Console.WriteLine($"\nSonraki müşteriş : {musteriler.Peek()}");

            Console.WriteLine($"\n{musteriler.Dequeue()} isimli müşterinin işlemi tamamlandı");

            Console.WriteLine("\nGüncel Kuyruk : ");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri);
            }
        }
    }
}
