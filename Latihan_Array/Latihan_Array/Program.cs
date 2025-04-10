using System;

namespace Latihan_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] angka;

            angka = new int[5];

            angka[0] = 10; 
            angka[1] = 20; 
            angka[2] = 30; 
            angka[3] = 40; 
            angka[4] = 50;

        for(int i = 0; i < angka.Length; i++)
        {
            Console.WriteLine($"Angka[{i}] = {angka[i]}");
        } 

        }
    }
}
