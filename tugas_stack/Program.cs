 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Single_Linked_List;
using Queue_Dinamis;
using Latihan_Stack_Dinamis;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue nilai_uts = new Queue();

            nilai_uts.enqueue(45);
            nilai_uts.enqueue(89);
            nilai_uts.enqueue(71);
            nilai_uts.enqueue(67);
            nilai_uts.enqueue(56);
            nilai_uts.enqueue(15);
            nilai_uts.enqueue(70);

            Stack remedial = new Stack();
            Stack lulus = new Stack();

            float total_r = 0;
            float total_l = 0;
    
            int jumlah_siswa = nilai_uts.getSize();

            float total_nilai = 0;
            Console.WriteLine("========================================");
            Console.WriteLine("Daftar Nilai UTS : " + nilai_uts.display());
            Console.WriteLine("========================================");

            while(!nilai_uts.isEmpty())
            {
                int a = nilai_uts.dequeue(); 
                total_nilai += a;

                if(a < 70)
                {
                    remedial.push(a);
                }
                else if(a >= 70 && a <= 100)
                {
                    lulus.push(a);
                }
            }

            Console.WriteLine("\n========================================");
            Console.WriteLine("Daftar Nilai UTS Remedi : " + remedial.ToString());
            Console.WriteLine("Daftar Nilai UTS Tuntas : " + lulus.ToString());
            Console.WriteLine("========================================");

            while(!remedial.isEmpty())
            {
                int b = remedial.pop();
                total_r+=b;
            }
            
            while(!lulus.isEmpty())
            {
                int c = lulus.pop();
                total_l+=c;
            }

            float rata_remed = total_r * 100/total_nilai;
            float rata_lulus = total_l * 100/total_nilai;

            Console.WriteLine("\n========================================");
            Console.WriteLine("Rata-Rata Nilai Remedi : " + rata_remed.ToString());
            Console.WriteLine("Rata-Rata Nilai Tuntas : " + rata_lulus.ToString());
            Console.WriteLine("========================================");




        }
    }
}