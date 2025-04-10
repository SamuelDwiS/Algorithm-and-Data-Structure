using System;

namespace review2
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[,] A = {{1, 2}, {3,4} };

            int[,] A = new int [2,2];
            A[0,0] = 1;
            A[0,1] = 2;
            A[1,0] = 3;
            A[1,1] = 4;

            int skalar = 3;

            int[,] B = new int[A.GetLength(0), A.GetLength(1)];


            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = A[i, j] * skalar;
                }
            }    

            Console.WriteLine("Hasil Perkalian Matriks A dengan Skalar 3:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++) 
                {
                    Console.Write(B[i, j] + " ");
                }
            Console.WriteLine();
            }
        }
    }
}
