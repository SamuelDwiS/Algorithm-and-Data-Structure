using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamuelDwi_latihan1_record
{
    public class Program
    {
        public record Waktu(int a, int b, int c);
        static Waktu KonversiDetik(int total_detik)
        {
            int jam = total_detik / 3600;
            int sisa = total_detik % 3600;
            int menit = sisa / 60 ;
            int detik = sisa % 60;

            return new Waktu(jam, menit, detik);
        }
        static void Main (string[] args)
        {
            Console.WriteLine("Masukkan Jumlah Detik: ");
            int input = int.Parse(Console.ReadLine());

            Waktu kirim_data = KonversiDetik(input);

            Console.WriteLine("Jadi: " + kirim_data.a + " jam");
            Console.WriteLine("Jadi: " + kirim_data.b + " menit");
            Console.WriteLine("Jadi: " + kirim_data.c + " detik");

        }
    }
}