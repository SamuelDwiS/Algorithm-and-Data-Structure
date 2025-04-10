using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamuelDwi_Single_Linked_List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Single_Linked_List senarai = new Single_Linked_List();
            senarai.addFirst(1);
            senarai.addFirst(2);
            senarai.addFirst(3);
            senarai.addFirst(4);
            senarai.addFirst(5);
            
            senarai.addLast(6);
            senarai.addLast(7);
            senarai.addLast(8);
            senarai.addLast(9);
            senarai.addLast(10);

            Console.WriteLine(senarai.ToString());

            senarai.removeFirst();
            senarai.removeLast();
            Console.WriteLine(senarai.ToString());

        }
    }   
}