using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Single_Linked_List;

namespace Latihan_Stack_Dinamis
{
    public class Main_Stack
    {
        public static void Main(string[]args)
        {
            Stack stk_dinamis = new Stack();

            stk_dinamis.push(13);
            stk_dinamis.push(36);
            stk_dinamis.push(28);
            stk_dinamis.push(47);
            stk_dinamis.push(81);

            Console.WriteLine("Stack dari awal : " + stk_dinamis.ToString());
            Console.WriteLine("Remove : " + stk_dinamis.pop());
            Console.WriteLine("Stack  : " + stk_dinamis.ToString());


        }
    }
}