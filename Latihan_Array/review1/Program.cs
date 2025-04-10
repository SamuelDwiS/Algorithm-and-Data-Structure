using System;

namespace review1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Nilai_Mahasiswa ={85,90,78,92,88};

            int total=0;
            for (int i=0; i <Nilai_Mahasiswa.Length; i++)
            {
                total +=Nilai_Mahasiswa[i];
            }
            
            double rataRata = (double)total / Nilai_Mahasiswa.Length;
            Console.WriteLine("rata-rata " + rataRata);
        }
    }
}
