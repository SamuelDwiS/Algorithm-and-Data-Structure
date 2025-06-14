using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R1
{
    public class MainClass_R1
    {
        static void count(int index)
        {
            Console.WriteLine(index);
            if (index < 2)
            {
                count(index + 1);
            }

            // index = 0 
            // Console.WriteLine(0);
            // if (0 < 2) 
            // {

                // index = index + 1 / 0 + 1 = 1
            //     Console.WriteLine(1);
            //     if (1 < 2)
            //     {

                    // index = index + 1 / 1 + 1 = 2
            //         Console.WriteLine(2);
            //         if (2 < 2)
            //         {
            //             TIDAK DIJALANKAN KARENA PARAMETER TIDAK TERPENUHI
            //         }
            //     }
            // }

        }

        public static void Main(string[] args)
        {
            count(0);


        }
    }
}