using System;

namespace Samuel_Dwi_latihan3_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] angka = {12, 15, 20, 25, 35, 42, 41, 11, 23, 27, 35};

            foreach(int num in angka)
            {
                if(num % 5 == 0)
                {
                    Console.WriteLine("Kelipatan 5: " + num);
                } else 
                {
                    Console.WriteLine("Bkn. Kel 5: " + num );
                }

            }
        }
    }
}
