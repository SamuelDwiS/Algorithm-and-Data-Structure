using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review5
{
    public class Program
    {
        public record Aritmatika(int angka1, int angka2, int tambah, int kurang);

        static Aritmatika tambah_kurang(int x, int y)
        {
            int penjumlahan = x + y;
            int pengurangan = x - y;
            return new Aritmatika(x, y, penjumlahan, pengurangan);
        }
        public static void Main(string[] args)
        {
            int bilangan_pertama = 50;
            int bilangan_kedua = 25;

            Aritmatika hanya_tambah_kurang = tambah_kurang(bilangan_pertama, bilangan_kedua);

            Console.WriteLine("Hasil Penjumlahan: " + hanya_tambah_kurang.tambah);
            Console.WriteLine("Hasil Pengurangan: " + hanya_tambah_kurang.kurang);
        }
    }
}