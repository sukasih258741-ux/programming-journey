using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_5._6_vinasukasih_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int angka;

			// Blok 'do' dieksekusi minimal 1 kali.
			do
			{
				Console.Write("Masukkan angka genap: ");

				// Mencoba membaca input dari pengguna
				if (!int.TryParse(Console.ReadLine(), out angka))
				{
					Console.WriteLine("Input tidak valid. Masukkan angka.");
					// Jika input tidak valid, set angka = 1 (ganjil) agar loop beralanjut
					angka = 1;
					continue; // Lanjutkan ke literasi berikutnya
				}

				// Memeriksa apakah angka tersebut ganjil
				if (angka % 2 != 0)
				{
					Console.WriteLine($"Angka {angka} adalah ganjil. Coba lagi.");
				}
			// Kondisi diperiksa si akhir. Loop berlankut selama angka Ganjil.
			} while (angka % 2 != 0);

			Console.WriteLine($"Selamat! Anda memasukkan angka genap: {angka}");
		}
	}
}
