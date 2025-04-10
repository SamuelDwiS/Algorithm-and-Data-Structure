using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace review2
{
    public class Program
    {
        public record Mahasiswa(string nama, int nim, string prodi);

        public static void Main(string[] args)
        {
            Mahasiswa aku = new Mahasiswa ("Raditya", 243567, "RPL");

            Console.WriteLine("Masukkan Nama: ");
            string nama = Console.ReadLine();

            Console.WriteLine("Masukkan NIM: ");
            int nim = int.Parse(Console.ReadLine());

            Console.WriteLine("Masukkan Prodi: ");
            string prodi = Console.ReadLine();

            Mahasiswa kamu = new Mahasiswa(nama, nim, prodi);

            Console.WriteLine("Bio Mhs 1");
            Console.WriteLine("Nama: " + aku.nama);
            Console.WriteLine("NIM: " + aku.nim);
            Console.WriteLine("Prodi: " + aku.prodi);

            Console.WriteLine("Bio Mhs 2");
            Console.WriteLine("Nama: " + kamu.nama);
            Console.WriteLine("NIM: " + kamu.nim);
            Console.WriteLine("Prodi: " + kamu.prodi);

        }
    }
}