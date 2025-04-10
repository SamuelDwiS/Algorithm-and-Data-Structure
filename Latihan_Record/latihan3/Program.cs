using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuelDwi_latihan3_record
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

        static int hitung_biaya_modifikasi(int durasi, bool sesama_operator)
        {

            int tarif_awal = 0;
            int tarif_lanjutan = 0;
            int biaya = 0;

            if(sesama_operator == true)
            {
                tarif_awal = 15;
                tarif_lanjutan = 3;
            } else
            {
                tarif_awal = 30;
                tarif_lanjutan = 10;
            }

            if(durasi <= 120)
            {
                biaya = durasi * tarif_awal;
            } else
            {
                biaya = (120 * tarif_awal) + ((durasi - 120) * tarif_lanjutan);
            }

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

            Console.Write("Apakah Panggilan Sesama Operator (true/false) ");
            string pilihan = Console.ReadLine();

            Pulsa kirim_waktu_awal = new Pulsa(jam_awal, menit_awal, detik_awal);
            Pulsa kirim_waktu_akhir = new Pulsa(jam_akhir, menit_akhir, detik_akhir);

            bool opsi = bool.Parse(Console.ReadLine());
            int total_durasi = hitung_durasi(kirim_waktu_awal, kirim_waktu_akhir);
            int total_biaya = hitung_biaya_modifikasi(total_durasi,opsi);

            if(opsi == true)
            {
                Console.WriteLine("Total Durasi " + total_durasi + " Detik. Total Biaya Penggunaan Pulsa Sesama Operator Rp " + total_biaya);
            } else
            {
                Console.WriteLine("Total Durasi " + total_durasi + " Detik. Total Biaya Penggunaan Pulsa Beda Operator Rp " + total_biaya);

            }

        }
    }
}