using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faktorial
{
    public class MainClass_Faktorial
    {
        public static int hitung_faktorial(int angka)
        {
            if (angka == 0 || angka == 1)
            {
                return 1;
            }
            else
            {
                return angka * hitung_faktorial(angka - 1);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Masukan sebuah bilangan: ");
            int bilangan = int.Parse(Console.ReadLine());

            Console.WriteLine("Faktorial dari angka " + bilangan + " adalah " + hitung_faktorial(bilangan));
        }
    }
}