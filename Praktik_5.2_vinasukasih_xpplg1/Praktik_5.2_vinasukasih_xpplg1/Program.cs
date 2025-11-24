using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Praktik_5._2_vinasukasih_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabel untuk menyimpan hasil penjumlahan 
            int total = 0;

            Console.WriteLine("Menghitung jumlah angka dari 1 sampai 5:");

            // Perulangan for dari 1 sampai 5
            for (int i = 1; i <= 5; i++)
            {
                // Tambahkan nilai i saat ini ke variabel total
                total = total + i; // Bisa juga ditulis sebagau: total += i;

                // Tampilkan proses penjumlahan di setiap langkah
                Console.WriteLine("Menambahkan " + i + ", total sementara = " + total);

                // Tampilkan hasil akhir setelah perulngan selesai
                Console.WriteLine("\nHasil akhir penjumlahan adalah: " + total);
            }
        }
    }
}
