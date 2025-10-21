using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_Fungsi_Rifa_XPPLG2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hitunglagi;// Variabel untuk menyimpan pilihan pengguna (y/n)

            //Perulangan do-While akan menjalankan blok kode setidaknya satu kali
            //Dan akan terus berjalan selama while terpenuhi
            do
            {
                Console.Clear(); //Membersihkan layar konsol untuk setiap perhitungan baru
                Console.WriteLine("---------- KALKULATOR SEDERHANA -----------");

                //Memanggil fungsi untuk menampilkan menu
                TampilkanMenu();

                Console.Write("Masukkan pilihan operasi (1-4) : ");
                string pilihan = Console.ReadLine();

                double angka1, angka2, hasil = 0;


                if (AmbilInputAngka(out angka1, out angka2))
                {
                    //struktur pemilihan switch-case untuk menentukan operasi
                    switch (pilihan)
                    {
                        case "1": //Penjumlahan
                            hasil = Tambah(angka1, angka2);
                            Console.WriteLine($"\n hasil : {angka1} + {angka2} = {hasil} ");
                            break;
                        case "2": //Pengurangan
                            hasil = Kurang(angka1, angka2);
                            Console.WriteLine($"\n hasil : {angka1} - {angka2} = {hasil} ");
                            break;
                        case "3": //Perkalian
                            hasil = Kali(angka1, angka2);
                            Console.WriteLine($"\n hasil : {angka1} * {angka2} = {hasil} ");
                            break;
                        case "4": //Pembagian
                                  //Penanganan khusus untuk pembagian dengan nol
                            if (angka2 == 0)
                            {
                                Console.WriteLine("\nError : Tidak dapat melakukan pembagian dengan nol.");
                            }
                            else
                            {
                                hasil = Bagi(angka1, angka2);
                                Console.WriteLine($"\n hasil : {angka1} / {angka2} = {hasil} ");
                            }
                            break;
                    }
                }
                //Menanyakan kepada pengguna apakah ingin menghitung lagi
                Console.Write("\nApakah anda ingin menghitung kembali (y/n) : ");
                hitunglagi = Console.ReadLine();
                //.Tolower() membuat input menjadi hruuf kecil, jadi 'Y' atau 'y' akan sama

            } while (hitunglagi.ToLower() == "y");

            // Pesan penutup jika pengguna memilih keluar
            Console.WriteLine("\nTerimakasih telah menggunakan kalkulator ini. " + "Tekan tombol apapun untuk keluar.");
            Console.ReadKey();
            }
            // Fungsi - Fungsi Bantuan 

            // Fungsi untuk menampilkan  menu pilihan 
            static void TampilkanMenu()
        {
            Console.WriteLine("Pilih operasi Matematika :");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }
        // Fungsi  untuk mengambil input angka dari pengguna 
        // menggunakan out karena fungsi ini mengembalikan lebih dari satu nilai
        static bool AmbilInputAngka(out double angka1, out double angka2)
        {
            Console.Write("Masukkan Angka Pertama : ");
            //double.TryParse akan mencoba mengkonversi string ke double
            //jika berhasil, return true dan nilainya disimpan di variabel 'angka1'.
            //jika gagal, retrun false
            if (!double.TryParse(Console.ReadLine(), out angka1))
            {
                Console.WriteLine("Input untuk angka pertama tidak valid.");
                angka2 = 0; // beri nilai default agar tidak error 
                return false;
            }

            Console.Write("Masukkan angka kedua : ");
            if (!double.TryParse(Console.ReadLine(), out angka2))
            {
                Console.WriteLine("Input untuk angka kedua tidak valid.");
                return false;
            }
            return true; // Jika kedua input valid

        }

        // Fungsi untuk operasi penjumlahan 
        static double Tambah(double a, double b)
        {
            return a + b;
        }
        static double Kurang(double a, double b)
        {
            return a - b;
        }
        static double Kali(double a, double b)
        {
            return a * b;
        }
        static double Bagi(double a, double b)
        {
            return a / b;
        }
        
    }
}
