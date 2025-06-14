using System;
using System.Collections.Generic;
using System.Linq;
using Single_Linked_List;

namespace Queue_Dinamis
{
    public class Queue
    {
        private SSL list;
        public Queue()
        {
            list = new SSL();
        }

        public void enqueue(int data)
        {
            list.addLast(data);
        }
        
        public int dequeue()
        {
            if(isEmpty())
            {
                throw new InvalidOperationException("Queue is Empty");
            }
            return list.removeFirst().getData();
        }

        public string display()
        {
            return list.ToString();
        }

        public Boolean isEmpty()
        {
            if(list.getSize() == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public int getSize()
        {
            return list.getSize();
        }


    }
}