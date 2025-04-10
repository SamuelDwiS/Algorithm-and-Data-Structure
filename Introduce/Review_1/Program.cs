using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Review_Satu
{
public class Review_1
{
    public static void Main(string[] args)
    {
        int masukan;
        Console.WriteLine("Masukan Bilangan :");
        masukan = int.Parse(Console.ReadLine());

    if (masukan % 2 == 0)
    {
        Console.WriteLine ("Bilangan {0} adalah Bil. Genap", masukan);
    }
    else
    {
        Console.WriteLine( "Bilangan {0} adalah Bil. Ganjil", masukan);
    }
    }
    }   
}