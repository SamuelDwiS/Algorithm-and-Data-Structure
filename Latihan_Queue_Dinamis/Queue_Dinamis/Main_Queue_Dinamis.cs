using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Single_Linked_List;

namespace Queue_Dinamis
{
    public class Main_Queue_Dinamis
    {
        public static void Main(string [] args)
        {
            Queue dinamis = new Queue();

            dinamis.enqueue(32);
            dinamis.enqueue(12);
            dinamis.enqueue(61);
            dinamis.enqueue(84);
            dinamis.enqueue(62);

            Console.WriteLine("Queue : " + dinamis.display());

            Console.WriteLine("Dequeue : " + dinamis.dequeue());
            Console.WriteLine("Queue setelah dequeue pertama : " + dinamis.display());

        }
    }
}