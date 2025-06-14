using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace queue_statis
{
    public class Queue
    {
        private int size;
        private int rear;
        private int front;
        private int[] elemen;

        public Queue(int jumlah_elemen)
        {
            this.size = 0;
            this.rear = 0;
            this.front = 0;
            this.elemen = new int [jumlah_elemen];
        }

        public void enqueue(int data)
        {
            if(getSize() != elemen.Length)
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
            for(int i = 0; i < getSize(); i++)
            {
                Console.WriteLine("Elemen index " + (front + i) + " : " + elemen[front + i]);
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