using System;

namespace Samuel_Dwi_latihan3_Matriks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan Jumlah Matriks");

            Console.Write("Indeks Pertama(Baris): ");
            int input_baris = int.Parse(Console.ReadLine());

            Console.Write("Indeks Kedua(Kolom): ");
            int input_kolom = int.Parse(Console.ReadLine());

            int [,] number = new int[input_baris,input_kolom];

            for(int i = 0; i < number.GetLength(0); i++)
            {
                for(int j = 0; j < number.GetLength(1); j++)
                {
                    Console.Write("Kolom "+ i + " Baris " + j +  " Masukkan Angka: ");
                    number[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for( int i = 0; i < number.GetLength(0); i++ )
            {
                for(int j = 0; j < number.GetLength(1); j++)
                {   
                    Console.Write(number[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Masukkan Indeks Baris: ");
            int cari_baris = int.Parse(Console.ReadLine());

            Console.Write("Masukkan Indeks Kolom: ");
            int cari_kolom = int.Parse(Console.ReadLine());

            if(cari_baris == 0 && cari_kolom == 0)
            {
                Console.WriteLine("Angka tidak valid");
            } else{
                Console.WriteLine("Nilai elemen dari baris " + cari_baris + " dan Kolom " + cari_kolom + " adalah " + number[cari_baris -1, cari_kolom -1]);
            }
            



        }
    }
}
