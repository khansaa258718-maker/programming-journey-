using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktik5._2_xpplg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable untuk menyimpan hasil penjumlahan
            int total = 0;

            Console.WriteLine("menghitung jumlah angka dari 1 sampai 5:");

            // perulangan for dari 1 hingga 5
            for (int i = 1; i <= 5; i++)
            {
                // tambahkan nilai i saat ini ke variable total
                total = total + i;// bisa juga di tulis sebagai:total += i;

                //tampilkan proses penjumlahan di setiap langkah
                Console.WriteLine("menambahkan" + i + ", total sementara + " + total);

                // tampilkan hasil akhir setelah perulangan selesai
                Console.WriteLine("\nhasil akhir penjumlahan adalah: " + total);

            }
        }
    }
}
