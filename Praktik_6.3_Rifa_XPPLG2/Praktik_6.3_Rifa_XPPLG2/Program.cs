using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_6._3_Rifa_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi variabel untuk menyimpan input 
            string inputUser = "";

            Console.WriteLine("Program akan terus berjalan hinggga anda mengetik 'keluar'. ");

            // Perulangan selama isi variabel inputUser TIDAK SAMA DENGAN "keluar"
            while (inputUser.ToLower() != "keluar")
            {
                Console.WriteLine("\nKetik sesuatu (atau 'keluar' untuk berhenti); ");
                inputUser = Console.ReadLine();

                Console.WriteLine("Anda mengetik : " + inputUser);
            }

            Console.WriteLine("\nPROGRAM SELESAI. TERIMA KASIH!");
        }
    }
}
