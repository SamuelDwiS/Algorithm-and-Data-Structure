using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan_Matriks
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int[,] angka = new int [3,3];

        //    angka[0,0] = 1; angka[0,1] = 2; angka [0,2] = 3;
        //    angka[1,0] = 4; angka[1,1] = 5; angka [1,2] = 6;
        //    angka[2,0] = 7; angka[2,1] = 8; angka [2,2] = 9;

        // for(int i = 0; i < angka.GetLength(0); i++)
        // {
        //     for (int j = 0; j < angka.GetLength(1); j++)
        //     {
        //         Console.Write(angka[i, j] + " ");
        //     }
        //     Console.WriteLine();
        // }

        int []  sebuah_angka = new int[5];

        sebuah_angka [0]= 10;
        sebuah_angka [1]= 50;
        sebuah_angka [2]= 25;
        sebuah_angka [3]= 90;
        sebuah_angka [4]= 70;

        int nilai_maks = int.MinValue;
        int nilai_min = int.MaxValue;
        for (int i = 0; i < sebuah_angka.Length; i++)
        {
            if(sebuah_angka[i] > nilai_maks)
            {
                nilai_maks = sebuah_angka[i];
            }

            if(sebuah_angka[i] < nilai_min)
            {
                nilai_min = sebuah_angka[i];
            }
        }
        Console.WriteLine("Nilai Maksimal: " + nilai_maks);
        Console.WriteLine("Nilai Minimal: " + nilai_min);

        // foreach (int angka in sebuah_angka)
        // {
        //     if(angka > nilai_maks) 
        //     {
        //         nilai_maks = angka;
        //     }
        //     if(angka < nilai_min)
        //     {
        //         nilai_min = angka;
        //         } 
        // }
        // Console.WriteLine("Nilai maksimal: "+ nilai_maks);
        // Console.WriteLine("Nilai minimal: " + nilai_min);




        }
    }
}
