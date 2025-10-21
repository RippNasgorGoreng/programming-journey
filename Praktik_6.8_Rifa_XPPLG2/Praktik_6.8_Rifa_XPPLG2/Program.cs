using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_6._8_Rifa_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangiPilihan;

            do
            {
                // ---- Blok Proses yang akan diulang ----
                Console.WriteLine("---------------------------------");
                Console.Write("Masukkan nama anda : ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama}! Proses telah selesai.");
                // ------------------------------------
                // Pertanyaan untuk mengulang 
                Console.Write("Apakah anda ingin mengulang lagi ? (ya/tidak) : ");
                ulangiPilihan = Console.ReadLine().ToLower();// Mengambil input dan mengubah ke huruf kecil

                Console.WriteLine();

                // Kondisi diperiksa di akhir : ulangi selama pengguna mengetik 'ya'
            } while (ulangiPilihan == "ya");
            Console.WriteLine("Terima kasih. Proram selesai.");
        }
    }
}
