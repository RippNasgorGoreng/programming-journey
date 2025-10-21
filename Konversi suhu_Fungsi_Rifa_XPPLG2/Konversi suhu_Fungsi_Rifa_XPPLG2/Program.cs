using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konversi_suhu_Fungsi_Rifa_XPPLG2
{
    internal class Program
    {
        static double CtoF(double C)
        {
            double F = (C * 9 / 5) + 32;
            return F;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Alat Konversi suhu Celcius ke Fahrenheit");
            Console.Write("Masukkan suhu dalam Celcius : "  );
            double c = Convert.ToDouble(Console.ReadLine());
            double f = CtoF(c);
            Console.WriteLine($"Suhunya dalam Fahrenheit = {f} °f");

        }
    }
}
