using System;

namespace review3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] angka = {1, 2, 3, 4, 5, 6, 7, 8, 9};

            Console.WriteLine("Angka :");
            for (int i = 0; i < angka.Length; i++)
            {
                if (angka[i] % 2 != 0)
                {
                    Console.WriteLine(angka[i]);
                }
            
            }
    }   }
}
