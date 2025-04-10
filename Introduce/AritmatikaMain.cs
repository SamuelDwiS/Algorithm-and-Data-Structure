using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BelajarSoC
{
    public class AritmatikaMain
    {
        public static void Main(string[] args)
        {
            Aritmatika iniObjek = new Aritmatika();
            int hasil_penjumlahan = iniObjek.tambah(12,12);
            Console.WriteLine(hasil_penjumlahan);
        }
    }
}