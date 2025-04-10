using System;

namespace Samuel_Dwi_latihan1_Matriks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] number = new int[3,3];
            number[0,0] = 1;
            number[0,1] = 2;
            number[0,2] = 3;

            number[1,0] = 4;
            number[1,1] = 5;
            number[1,2] = 6;
            
            number[2,0] = 7;
            number[2,1] = 8;
            number[2,2] = 9;

        for( int k = 0; k < number.GetLength(0); k++ )
        {
            for(int h = 0;  h < number.GetLength(1); h++)
            {   
                Console.Write(number[k,h] + " ");
            }
            Console.WriteLine();
        }

        Console.Write("Masukkan Kolom (1-3): ");
        int input = int.Parse(Console.ReadLine());

        if(input < 0 && input > 3)
        {
            Console.WriteLine("Angka tidak valid ");
        }
        else
        {
            int jumlah = 0;
            for(int a = 0; a < 3; a++)
            {
                jumlah += number[a,input - 1];
            }
            Console.WriteLine("Total nilai di kolom " + input + " adalah " + jumlah );
        }


        }
    }
}
