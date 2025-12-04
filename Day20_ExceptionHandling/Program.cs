using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = int.Parse("abc");

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Hata oluştu : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Her durumda çalışan blok.");
            }
        }
    }
}
