using System;

namespace review2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] suhu = { 30.5, 28.7, 35.2, 33.0, 27.9};
            double suhuTertinggi = suhu[0];
            double suhuTerendah = suhu[0];

            for (int i = 1; i < suhu.Length; i++)
            {
                if (suhu[i] > suhuTertinggi)
                    {
                        suhuTertinggi = suhu[i];
                    }
                if (suhu[i] < suhuTerendah)
                    {
                        suhuTerendah = suhu[i];
                    }
            }
            Console.WriteLine("Suhu Tertinggi: " + suhuTertinggi);
            Console.WriteLine("Suhu Terendah: " + suhuTerendah);
        
        }
    }
}
