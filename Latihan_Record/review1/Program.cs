using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace review1
{
    class Program
    {
        public record Mahasiswa(string nama, int nim, string prodi);
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa("Prabowo", 2033020,"RPL");

            Console.WriteLine("Nama: " + mhs.nama);
            Console.WriteLine("Nim: " + mhs.nim);
            Console.WriteLine("Prodi: " + mhs.prodi);

        }
    }
}