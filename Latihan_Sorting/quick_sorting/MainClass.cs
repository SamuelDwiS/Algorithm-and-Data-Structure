using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quick_sorting
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quick Sort Algorithm");

            // int[] data = new int[9];
            // data[0] = 23;
            // data[1] = 45;
            // data[2] = 12;
            // data[3] = 24;
            // data[4] = 56;
            // data[5] = 34;
            // data[6] = 27;
            // data[7] = 23;
            // data[8] = 26;

            int[] data = { 23, 45, 12, 24, 56, 34, 37, 23, 26 };

            Console.WriteLine("Sebelum diurutkan :");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");

            }
            Console.WriteLine(" ");

            LarikDescend.quickSort(data, 0, data.Length - 1);

            Console.WriteLine("Quick Sorting : ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine(" ");

        }
    }
}