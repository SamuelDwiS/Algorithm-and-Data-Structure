using System;

namespace Samuel_Dwi_latihan1_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] angka  = {2,4,6,8,10};
            int total = 0;

            foreach(int number in angka)
            {
                total+=number;
            }
            Console.WriteLine("Nilai total: " + total);
        }
    }
}
