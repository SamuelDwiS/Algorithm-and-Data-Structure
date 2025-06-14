using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan_Queue_Melingkar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue statis_melingkar = new Queue(5);

            statis_melingkar.enqueue(23);
            statis_melingkar.enqueue(44);
            statis_melingkar.enqueue(34);
            statis_melingkar.enqueue(45);
            statis_melingkar.enqueue(34);

            statis_melingkar.display();
            Console.WriteLine("Size : " + statis_melingkar.getSize());

            Console.WriteLine("Remove : " + statis_melingkar.dequeue());
            statis_melingkar.display();
            Console.WriteLine("Size : " + statis_melingkar.getSize());

            statis_melingkar.enqueue(696);
            statis_melingkar.display();
            Console.WriteLine("Size : " + statis_melingkar.getSize());
        }
    }
}