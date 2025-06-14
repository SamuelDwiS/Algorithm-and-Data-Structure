using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R2
{
    public class MainClass_R2
    {
        static void count(int index)
        {
            if (index < 2)
            {
                count(index + 1);
            }
            Console.WriteLine(index);

            // if( 0 < 2) | index 0 
            // {
            //     if(1 < 2) | index + 1 / 0 + 1 = 1
            //     {
            //         if(2 < 2) | index + 1 / 1 + 1 = 2
            //         {
                        // tidak menjalankan count (index +1)         
            //         }

            //          Console.WriteLine(2);      
            //     }

            //      Console.WriteLine(1);
            // }
            // Console.WriteLine(0);

        }
        public static void Main(string[] args)
        {
            count(0);
        }
    }
}