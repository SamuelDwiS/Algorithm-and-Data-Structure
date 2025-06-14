using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Natural
{
    public class MainClass
    {
        static int natural_number(int angka)
        {
            if (angka == 1)
            {
                return 1;
            }
            else
            {
                return angka + natural_number(angka - 1);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Masukan sebuah bilangan: ");
            int bilangan = int.Parse(Console.ReadLine());

            Console.WriteLine("Penjumlahan dari 1 sampai " + bilangan + " adalah " + natural_number(bilangan));
        }
    }
}