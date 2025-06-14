using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Single_Linked_List;

namespace Latihan_Stack_Dinamis
{
    public class Stack
    {
        private SSL list; 
        public Stack()
        {
            list = new SSL();
        }

        public void push(int elemen)
        {
            list.addFirst(elemen);
        }

        public int getSize()
        {
            return list.getSize();
        }

        public int pop()
        {
            if(isEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return 0;
            }
            else
            {
            return list.removeFirst().getData();

            }
        }

        public Boolean isEmpty()
        {
            if(list.getSize() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return list.ToString();
        }
    }
}