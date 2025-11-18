using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace projek_akhir_data_siswa
{

       internal class program
       {
            // fungsi untuk menghitung rata-rata nilai
            static double HitungRataRata(int[] nilai)
            {
            int total = 0; // variabel untuk menyimpan total nilai

            // perulangan for untuk menjumlahkan semua nilai
            for (int i = 0; i < nilai.Length; i++)
            {
                total = total + nilai[i];
            }

            // hasil dibagi jumlah data untuk dapat rata-rata
            return (double)total / nilai.Length;
        }

        static void Main(string[] args)
        { 
                string nama;
                int jumlahMapel;

                Console.WriteLine("=== PROGRAM NILAI SISWA ===");

                // Input nama siswa
                Console.Write("Masukkan nama siswa: ");
                nama = Console.ReadLine();

                // Input jumlah mata pelajaran
                Console.Write("Masukkan jumlah mata pelajaran: ");
                jumlahMapel = int.Parse(Console.ReadLine());

                // Membuat array untuk menampung nilai siswa
                int[] nilai = new int[jumlahMapel];

                // Input nilai dengan perulangan for
                for (int i = 0; i < jumlahMapel; i++)
                {
                    Console.Write("Masukkan nilai ke-" + (i + 1) + ": ");
                    nilai[i] = int.Parse(Console.ReadLine());
                }

                // Menghitung rata-rata menggunakan fungsi
                double rata = HitungRataRata(nilai);

                // Percabangan untuk menentukan grade
                char grade;
                if (rata >= 90)
                    grade = 'A';
                else if (rata >= 80)
                    grade = 'B';
                else if (rata >= 70)
                    grade = 'C';
                else if (rata >= 60)
                    grade = 'D';
                else
                    grade = 'E';

                // Menampilkan hasil nilai siswa
                Console.WriteLine("\n=== HASIL NILAI SISWA ===");
                Console.WriteLine("Nama Siswa     : " + nama);
                Console.WriteLine("Nilai Rata-rata: " + rata);
                Console.WriteLine("Grade          : " + grade);

                // Perulangan while untuk motivasi
                int ulang = 0;
                while (ulang < 1)
                {
                    Console.WriteLine("\nTetap semangat belajar ya, " + nama + "!");
                    ulang++;
                }

                // Switch untuk menampilkan keterangan
                switch (grade)
                {
                    case 'A':
                        Console.WriteLine("Keterangan: Sangat Baik!");
                        break;
                    case 'B':
                        Console.WriteLine("Keterangan: Baik, pertahankan!");
                        break;
                    case 'C':
                        Console.WriteLine("Keterangan: Cukup, tingkatkan lagi!");
                        break;
                    case 'D':
                        Console.WriteLine("Keterangan: Kurang, perlu belajar lebih giat!");
                        break;
                    default:
                        Console.WriteLine("Keterangan: Sangat kurang, ayo semangat belajar!");
                        break;
                }

                Console.WriteLine("\n=== Program Selesai ===");
                Console.ReadKey(); // agar program tidak langsung tertutup
            }
        }
       
}

