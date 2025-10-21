using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_7._2_Fungsi_Rifa_XPPLG2
{
    internal class Program
    {
        static void sapaNama(string nama)
        {
            Console.WriteLine("Halo, " + nama + "!");
            Console.WriteLine("Semangat belajar C# hari ini! ");
        }
        static void Main(string[] args)
        {
            Console.Write(" Masukkan Nama Anda : ");
            string namaSiswa = Console.ReadLine();
            sapaNama(namaSiswa); // Memanggil fungsi dengan argumen
        }
    }
}
