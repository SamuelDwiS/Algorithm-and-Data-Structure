using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan_Queue_Melingkar
{
    public class Queue
    {
        private int size;
        private int front;
        private int rear;
        private int[] elemen;

        public Queue(int jumlah_elemen)
        {
            this.size = 0;
            this.front = 0;
            this.rear = 0;
            this.elemen = new int[jumlah_elemen];
        }

        public void enqueue(int data)
        {
            if (rear == elemen.Length)
            {
                rear = 0;
            }

            if (getSize() != elemen.Length)
            {
                elemen[rear] = data;
                rear++;
                size++;
            }
            else
            {
                Console.WriteLine("Queue is Full");
            }
        }

        public int dequeue()
        {
            if(front == elemen.Length)
            {
                front = 0;
            }
            if(isEmpty())
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
              int deleted = elemen[front];
              front++;
              size--;
              return deleted;  
            }
            return 0;
        }

        public void display()
        {
            if(rear <= front && front > 0)
            {
                int x = 0;
                for(int i = front; i < elemen.Length; i++)
                {
                    Console.WriteLine("Elemen index " + (front + x ) + " : " + elemen[front + x]);
                    x++;
                }
                for(int i = 0; i < rear; i++)
                {
                    Console.WriteLine("Elemen index " + i + " : " + elemen[i]);
                }
            }
            else
            {
                for(int i =  0; i < getSize(); i++)
                {
                    Console.WriteLine("Elemen Index " + (front + i) + " : " + elemen[front + i]);
                }
            }
        }
        public Boolean isEmpty()
        {
            if(getSize() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getSize()
        {
            return this.size;
        }

        public void setSize(int size)
        {
            this.size = size;
        }

    }
}