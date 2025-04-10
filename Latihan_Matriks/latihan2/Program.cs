using System;

namespace Samuel_Dwi_latihan2_Matriks
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int[,] number = new int[3,3];
            number[0,0] = 1;
            number[0,1] = 0;
            number[0,2] = 0;

            number[1,0] = 0;
            number[1,1] = 1;
            number[1,2] = 0;
            
            number[2,0] = 0;
            number[2,1] = 0;
            number[2,2] = 1;
        
       for( int i = 0; i < number.GetLength(0); i++ )
        {
            for(int j = 0;  j < number.GetLength(1); j++)
                {   
                    Console.Write(number[i,j] + " ");
                }
            Console.WriteLine();
        }
        
        int cek_identitas_1 = 0;
        int cek_identitas_2 = 0; 
        
        for (int i = 0; i < number.GetLength(0); i++)
        {
            for (int j = 0; j < number.GetLength(1); j++)
            {
                if(i == j && number[i, j] != 1)
                {
                    cek_identitas_1 = 1;
                }
                if(i != j && number[i, j] != 0)
                {
                    cek_identitas_1 = 1;
                }
            }
        }

        for(int i = 0; i < number.GetLength(0); i++)
        {
            for(int j = 0; j < number.GetLength(0); j++)
            {
                if( i + j == number.GetLength(0)-1 )
                {
                    if(number[i, j] != 1)
                    {
                        cek_identitas_2 = 1;
                    }
                }
            }
        }
        
        if (cek_identitas_1 == 0)
        {
            Console.WriteLine("Matriks adalah matriks identitas.");
        }
        else if(cek_identitas_2 == 0)
        {
            Console.WriteLine("Matriks adalah matriks identitas.");
        }
        else
        {
            Console.WriteLine("Bukan Matriks Identitas");
        }


        }
    }
}
    