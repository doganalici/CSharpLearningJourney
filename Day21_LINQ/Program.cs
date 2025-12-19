using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Ahmet", Age = 20, Grade = 75 },
                new Student(){ Id = 2, Name = "Mehmet", Age = 22, Grade = 82 },
                new Student(){ Id = 3, Name = "Ayşe", Age = 19, Grade = 91 },
                new Student(){ Id = 4, Name = "Fatma", Age = 21, Grade = 65 },
                new Student(){ Id = 5, Name = "Ali", Age = 23, Grade = 88 }
            };

            Console.WriteLine("=== 1) 80 üzeri notu olanlar ===");
            var highGrades = students.Where(s => s.Grade > 80);

            foreach (var s in highGrades)
            {
                Console.WriteLine($"{s.Name} - {s.Grade}");
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("=== 2) Yaşı 20'den Küçük Olanlar ===");
            var youngStudents = students.Where(s => s.Age < 20);
            foreach (var s in youngStudents)
            {
                Console.WriteLine($"{s.Name} - {s.Age}");
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("=== 3) Notlara Göre Sıralama (Küçükten → Büyüğe) ===");
            var ordered = students.OrderBy(s => s.Grade);
            foreach (var s in ordered)
            {
                Console.WriteLine($"{s.Name} - {s.Grade}");
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("\n=== 4) Sadece İsimleri Listeleme (Select) ===");
            var names = students.Select(s => s.Name);
            foreach (var s in names)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("\n=== 5) En Yüksek Notu Alan Öğrenci ===");
            var topStudents = students.OrderByDescending(s => s.Grade).First();
            Console.WriteLine($"{topStudents.Name} = {topStudents.Grade}");
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }
}
