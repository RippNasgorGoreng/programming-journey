using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_2_Praktik_6_Rifa_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int penambah = 1;

            Console.WriteLine("Nilai awal = " + total );
            while (total < 15)
            {
                Console.WriteLine("Nilai ditambah dengan " + penambah);
                total = total + penambah;
                penambah++;
                Console.WriteLine("Nilai saat ini = " + total + "\n");
            }

            Console.WriteLine("Total = " + total);
        }
    }
}
