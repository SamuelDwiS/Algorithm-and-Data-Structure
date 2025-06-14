using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samuel_Dwi_Soal_3
{
    public class MainClass
    {
        static void count(int angka)
        {
            Console.WriteLine(angka);
            if(angka < 5)
            {
                count(angka + 1);
            }
        }
        static void Main(string []args)
        {
            Console.Write("Masukan angka: ");
            int bil = int.Parse(Console.ReadLine());
            count(bil);
        }
    }
}