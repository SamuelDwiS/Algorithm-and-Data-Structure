using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace queue_statis
{
    public class Main_Queue
    {
        public static void Main(string[] args)
        {
            Queue statis_antrian = new Queue(5);

            statis_antrian.enqueue(2);
            statis_antrian.enqueue(11);
            statis_antrian.enqueue(35);
            statis_antrian.enqueue(45);
            statis_antrian.enqueue(85);

            statis_antrian.display();
            Console.WriteLine("Size : " + statis_antrian.getSize());

            Console.WriteLine("Remove : " + statis_antrian.dequeue());
            statis_antrian.display();
            Console.WriteLine("Size : " + statis_antrian.getSize());
           

        }
    }
}