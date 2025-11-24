using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_5._8_vinasukasih_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangiPilihan;

            do
            {
                // --- Blok Proses yang Akan Diulang ---
                Console.WriteLine("----------------------------------");
                Console.Write("Masukkan nama anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama}! Proses telah selesai.");
                // -------------------------------------
                // Pertanyaan untuk Mengulang
                Console.Write("Apakah Anda ingin mengulang lagi? (ya/tidak): ");
                ulangiPilihan = Console.ReadLine().ToLower(); // Mengambil input dan mengubah ke huruf kecil

                Console.WriteLine(); // Baris kosong untuk kerapian 

                // Kondisi diperiksa di akhir: Ulangi selama pengguna mengetik "ya"
            } while (ulangiPilihan == "ya");
              Console.WriteLine("Terima kasih, Program selesai.");
        }
    }
}
