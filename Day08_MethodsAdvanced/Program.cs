using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_MethodsAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Topla(3, 5));
            Console.WriteLine(Topla(3.5, 6.7));
            Console.WriteLine(Topla(1, 2, 3));
        }

        //int parametreli
        public static int Topla(int a, int b)
        {
            return a + b;
        }

        //double parametreli
        public static double Topla(double a, double b)
        {
            return a + b;
        }

        //3 parametreli
        public static int Topla(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
