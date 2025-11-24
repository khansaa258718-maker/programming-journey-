using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_praktek6_ke_1
{
    internal class Program
    { }

namespace ArraySiswa
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Deklarasi array untuk menyimpan data siswa
                string[] namaSiswa = new string[3];
                char[] jenisKelamin = new char[3];
                string[] kelas = new string[3];

                // Input data siswa
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Masukkan nama siswa ke-{i + 1}: ");
                    namaSiswa[i] = Console.ReadLine();

                    Console.Write($"Masukkan jenis kelamin (L/P): ");
                    jenisKelamin[i] = Console.ReadLine()[0]; // Ambil karakter pertama sebagai jenis kelamin

                    Console.Write($"Masukkan kelas: ");
                    kelas[i] = Console.ReadLine();

                    Console.WriteLine(); // Baris kosong untuk memisahkan input siswa
                }

                // Tampilkan data siswa
                Console.WriteLine("=== Data Siswa ===");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Nama: {namaSiswa[i]} | JK: {jenisKelamin[i]} | Kelas: {kelas[i]}");
                }

                Console.ReadKey(); // Menunggu tombol ditekan sebelum menutup konsol
            }
        }
    }
}
    
