using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samuel_Dwi_Soal_1
{
    public class Program
    {
        public static void print_text(int jumlah)
        {
            if (jumlah >= 1 && jumlah != 0)
            {
                print_text(jumlah - 1);
                Console.WriteLine("Hello (" + jumlah +")");

            }
            
        }
        public static void Main(string[] args)
        {
            Console.Write("Masukan angka: ");
            int bil = int.Parse(Console.ReadLine());
            print_text(bil);
        }
    }
}