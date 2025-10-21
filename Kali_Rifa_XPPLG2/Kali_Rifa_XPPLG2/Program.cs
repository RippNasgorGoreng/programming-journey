using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kali_Rifa_XPPLG2
{
    internal class Program
    {
        static double HitungKali(double angka1, double angka2, double angka3)
        {
            double hasil = angka1 * angka2 * angka3;
            return hasil;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan Angka Pertama   : ");
            double angka1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Masukkan Angka Kedua     : ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Angka Ketiga    : ");
            double angka3 = Convert.ToDouble(Console.ReadLine());


            double hasil = HitungKali(angka1, angka2, angka3);
            Console.WriteLine("Hasil perkalian = " + hasil);
        }
    }
}
