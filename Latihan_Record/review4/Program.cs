using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review4
{
    public class program
    {
        public record murid(string nama, int umur, int[]nilai);

        public static void Main(string[] args)
        {
            murid siswa = new murid("azril", 20, new int[] {85,90,70});

            Console.WriteLine($"{siswa.nama} nilai: {string.Join(",", siswa.nilai)}");
        }
    }
}