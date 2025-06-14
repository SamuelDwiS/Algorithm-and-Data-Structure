using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibo
{
    public class MainClass
    {
        static int fibonacci(int angka)
        {
            if (angka <= 0)
            {
                return 0;
            }
            else if (angka <= 1)
            {
                return 1;
            }
            else
            {
                return fibonacci(angka - 2) + fibonacci(angka - 1);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Masukan sebuah bilangan: ");
            int bilangan = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci " + bilangan + " : " + fibonacci(bilangan));

        }
    }
}