using System;

namespace case1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Masukkan Jumlah: ");
            int jumlah = int.Parse(Console.ReadLine());
            string [] nama = new string [jumlah];


            Console.WriteLine("Masukkan nama:");
            for (int i = 0; i < nama.Length; i++)
            {
                nama[i] = Console.ReadLine();
            }
            
            Console.WriteLine("Masukkan Angka: ");
            for(int a = nama.Length - 1 ; a >= 0; a--)
            {
                Console.WriteLine("Nama: " + nama[a]);
            }


        }
    }
}
