using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_2_20_okt_xpplg_1
{
    internal class Program
    {
            public static double RataRata(double a, double b, double c)
            {
                return (a + b + c) / 3;
            }

            public static void Main(string[] args) 
            {
                double nilai1 = 7.5;
                double nilai2 = 8.0;
                double nilai3 = 9.5;

                double rata = RataRata(nilai1, nilai2, nilai3);
                Console.WriteLine($"Rata-rata dari {nilai1}, {nilai2}, dan {nilai3} adalah: {rata}");
            }
        }
    }