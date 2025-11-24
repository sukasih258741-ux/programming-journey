using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_5._3_vinasukasih_xpplg1
{
    internal class Program
    {
		static void Main(string[] args)
		{
			// Inisialisasi variabel untuk menyimpan input
			string inputUser = "";

			Console.WriteLine("Program akan terus berjalan hingga Anda mengetik 'keluar'.");

			// Perulangan selama inputUser TIDAK SAMA DENGAN "keluar"
			while (inputUser.ToLower() != "keluar")
			{
				Console.Write("\nKetik sesuatu (atau 'keluar' untuk berhenti): ");
				inputUser = Console.ReadLine();

				Console.WriteLine("Anda mengetik: " + inputUser);
			}

			    Console.WriteLine("\nProgram selesai. Terima kasih!");
		}
	}
}
