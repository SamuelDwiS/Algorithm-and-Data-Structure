using System;

namespace review1
{
    class Program
    {
        static void Main(string[] args)
        {
          int [,] A = new int [2,2];
          A[0,0] = 1;
          A[0,1] = 2;
          A[1,0] = 3;
          A[1,1] = 4;

          int [,] B = new int [2,2];
          B[0,0] = 5;
          B[0,1] = 6;
          B[1,0] = 7;
          B[1,1] = 8;
          

          int[,] C = new int[A.GetLength(0), A.GetLength(1)];
          // int[,] A ={ { 1,2 }, {3,4} };
          // int[,] B ={ { 5,6 }, {7,8} };  
          

          for(int i = 0; i < A.GetLength(0); i++)
          {
            for(int j = 0; j < A.GetLength(1); j++)
            {
                C[i,j] = A[i,j] + B[i,j];
            }
          }  

          Console.WriteLine("Hasil Penjumlahan Matriks A + B: ");
          for(int i = 0; i < C.GetLength(0); i++)
          {
            for(int j = 0; j < C.GetLength(1); j++)
            {
                Console.Write(C[i,j] + " ");
            }
            Console.WriteLine();
          }            
        }
    }
}
