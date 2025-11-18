using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projek_Akhir_SmartFinance_vinasukasih_xpplg1
{
	internal class Program
	{
		// Fungsi untuk menampilkan teks dengan efek loading
		static void Loading(string teks)
		{
			Console.Write(teks);
			for (int i = 0; i < 3; i++)
			{
				Console.Write(".");
				Thread.Sleep(300);
			}
			Console.WriteLine();
		}

		// Fungsi untuk menampilkan ringkasan pemasukan, pengeluaran, dan saldo
		static void TampilkanRingkasan(double[] transaksi, string[] jenis, int jumlah)
		{
			double totalPemasukan = 0, totalPengeluaran = 0;

			// Menghitung total pemasukan & total total pengeluaran
			for (int i = 0; i < jumlah; i++)
			{
				if (jenis[i].ToLower() == "pemasukan")
					totalPemasukan += transaksi[i];

				else if (jenis[i].ToLower() == "pengeluaran")
					totalPengeluaran += transaksi[i];
			}

			double saldoAkhir = totalPemasukan - totalPengeluaran;

			// Menampilkan hasil ringkasan
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\n=== RINGKASAN KEUANGAN ===");
			Console.ResetColor();
			Console.WriteLine($"Total Pemasukan : Rp {totalPemasukan}");
			Console.WriteLine($"Total Pengeluaran : Rp {totalPengeluaran}");
			Console.WriteLine($"Saldo Akhir : Rp {saldoAkhir}");
		}

		// Fungsi untuk menampilkan semua transaksi
		static void TampilkanTransaksi(string[] jenis, double[] nominal, string[] keterangan, int jumlah)
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("\n=== RIWAYAT TRANSAKSI ===");
			Console.ResetColor();

			if (jumlah == 0) // Jika belum ada transaksi
			{
				Console.WriteLine("Belum ada transaksi yang dicatat.");
				return;
			}

			// Loop untuk menampilkan semua transaksi
			for (int i = 0; i < jumlah; i++)
			{
				Console.WriteLine($"{i + 1}. [{jenis[i]}] Rp {nominal[i]} - {keterangan[i]}");
			}
		}

		static void Main(string[] args)
		{
			// Array sebagai penyimpanan data transaksi 
			string[] jenisTransaksi = new string[100];
			double[] nominalTransaksi = new double[100];
			string[] keterangan = new string[100];
			int jumlahTransaksi = 0;

			int menu;

			// Tampilan awal aplikasi
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("======================================");
			Console.WriteLine("   WELCOME TO SMARTFINANCE TRACKER ");
			Console.WriteLine("======================================");
			Console.ResetColor();

			// Perulangan utama menu program
			do
			{
				// Menampilkan menu
				Console.WriteLine("\n=== MENU UTAMA ===");
				Console.WriteLine("1. Tambah Transaksi");
				Console.WriteLine("2. Lihat Riwayat Transaksi");
				Console.WriteLine("3. Lihat Ringkasan Saldo");
				Console.WriteLine("4. Keluar");
				Console.Write("Pilih menu (1-4): ");

				// Validasi input menu
				if (!int.TryParse(Console.ReadLine(), out menu))
				{
					Console.WriteLine("Input tidak valid!");
					continue;
				}

				switch (menu)
				{
					case 1:
						// Input data transaksi
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("\n=== TAMBAH TRANSAKSI ===");
						Console.ResetColor();

						Console.Write("Jenis (Pemasukan/Pengeluaran): ");
						jenisTransaksi[jumlahTransaksi] = Console.ReadLine();

						Console.Write("Nominal (Rp): ");
						nominalTransaksi[jumlahTransaksi] = double.Parse(Console.ReadLine());

						Console.Write("Keterangan: ");
						keterangan[jumlahTransaksi] = Console.ReadLine();

						jumlahTransaksi++; // Menambah jumlah data yang tersimpan

						Loading("Menyimpan data");
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("Transaksi berhasil disimpan!");
						Console.ResetColor();
						break;

					case 2:
						// Menampilkan riwayat transaksi
						TampilkanTransaksi(jenisTransaksi, nominalTransaksi, keterangan, jumlahTransaksi);
						break;

					case 3:
						// Menampilkan ringkasan saldo
						TampilkanRingkasan(nominalTransaksi, jenisTransaksi, jumlahTransaksi);
						break;

					case 4:
						// Keluar dari program
						Console.ForegroundColor = ConsoleColor.Yellow;
						Loading("\nMenutup aplikasi");
						Console.WriteLine("Terima kasih telah menggunakan SmartFinance!");
						Console.ResetColor();
						break;

					default:
						Console.WriteLine("Pilihan tidak valid!");
						break;
				}

			} while (menu != 4); // Program berjalan terus sampai memilih keluar
		}
	}
}