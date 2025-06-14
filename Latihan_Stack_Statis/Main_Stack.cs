using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan_Stack_Statis
{
    public class Main_Stack
    {
        static void Main(string[] args)
        {
            Stack percobaan = new Stack(5);
            percobaan.push(27);
            percobaan.push(34);
            percobaan.push(28);
            percobaan.push(47);
            percobaan.push(69);

            percobaan.display();
            Console.WriteLine("Size : " + percobaan.getSize());

            
            Console.WriteLine("\nRemove : " + percobaan.pop());

            percobaan.display();
            Console.WriteLine("Size : " + percobaan.getSize());

            

        }
    }
}