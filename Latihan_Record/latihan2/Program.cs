using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuelDwi_latihan2_record
{
    public class Program
    {
        public record Pulsa(int jam, int menit, int detik);

        static int hitung_durasi(Pulsa awal_waktu, Pulsa akhir_waktu)
        {
            int total_detik_awal = (awal_waktu.jam * 3600) + (awal_waktu.menit * 60) + awal_waktu.detik;
            int total_detik_akhir = (akhir_waktu.jam * 3600) + (akhir_waktu.menit * 60) + akhir_waktu.detik;
            int durasi = total_detik_akhir - total_detik_awal;
            
            return durasi;
        }

        static int hitung_biaya(int total_durasi)
        {
            int tarif_perdetik = 25;
            int biaya = total_durasi * tarif_perdetik;

            return biaya;
        }


        static void Main(string[] args)
        {
            Console.Write("Masukkan Jam Awal: ");
            int jam_awal = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Menit Awal: ");
            int menit_awal = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Detik Awal: ");
            int detik_awal = int.Parse(Console.ReadLine());


            Console.Write("\nMasukkan Jam Akhir: ");
            int jam_akhir = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Menit Akhir: ");
            int menit_akhir = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Detik Akhir: ");
            int detik_akhir = int.Parse(Console.ReadLine());

            Pulsa kirim_waktu_awal = new Pulsa(jam_awal, menit_awal, detik_awal);
            Pulsa kirim_waktu_akhir = new Pulsa(jam_akhir, menit_akhir, detik_akhir);

            int total_durasi = hitung_durasi(kirim_waktu_awal, kirim_waktu_akhir);
            int total_biaya = hitung_biaya(total_durasi);


            Console.WriteLine("Total Durasi " + total_durasi + " Detik. Total Biaya Penggunaan Pulsa Rp " + total_biaya);


        }
    }
}