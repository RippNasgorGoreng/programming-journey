using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_6._6_Rifa_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angka;

            // BLOK 'DO" AKAN DIEKSEKUSI MINIMAL SATU KALI.
            do
            {
                Console.Write("Masukkan angka genap: ");
                //MENCOBA MEMBACA INPUT DARI PENGGUNA 
                if (!int.TryParse(Console.ReadLine(), out angka))
                {
                    Console.WriteLine("Input tidak valid. Silahkan masukkan angka.");
                    //Jika input tidak valid, set angka = 1 (ganjil) agar loop berlanjut 
                    angka = 1;
                    continue; // Lanjutkan ke literasi berikutnya 
                }
                //Memeriksa apakah angka tersebut ganjil 
                if (angka % 2 != 0)
                {
                    Console.WriteLine($"Angka {angka} adalah ganjil. coba lagi! ");
                }
                // Kondisi diperiksa di akhir. loop berlanjut selama angka ganjil.
            }while (angka  % 2 != 0);
            Console.WriteLine($"Selamat! Anda memasukkan angka genap : {angka}");
        }
    }
}
