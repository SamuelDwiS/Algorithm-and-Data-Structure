using System;

namespace Samuel_Dwi_latihan2_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            float [] suhu =  new float [5];


            for (int i = 0; i < suhu.Length; i++)
            {
                Console.Write("Masukkan angka: ");
                suhu [i] = float.Parse(Console.ReadLine());
            }

            foreach(float nilai in suhu)
            {
                if(nilai > 30)
                {
                    Console.WriteLine("Nilai suhu : " + nilai);
                }
            }


        }
    }
}
