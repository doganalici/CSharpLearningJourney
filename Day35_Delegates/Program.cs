using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Islem islem;

            islem = Topla;
            Console.WriteLine(islem(3, 4));

            islem = Carp;
            Console.WriteLine(islem(3, 4));
        }

        static int Topla(int a, int b)
        {
            return a + b;
        }

        static int Carp(int a, int b)
        {
            return a * b;
        }
    }
    public delegate int Islem(int a, int b);

}
