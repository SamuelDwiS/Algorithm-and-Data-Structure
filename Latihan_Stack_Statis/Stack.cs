using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan_Stack_Statis
{
    public class Stack
    {
        private int front;
        private int size;
        private int[] elemen;

        public Stack(int size)
        {
            this.size = 0;
            front = -1;
            elemen = new int [size];
        }

        public void display()
        {
            for(int i = 0; i <= this.front; i++)
            {
                Console.WriteLine("Data " + ((front - i) + 1) + " : " + elemen[front - i]);
            }
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
                this.size --;
                return front--;
            }
        }
        public void push(int data)
        {
            if(this.size < this.elemen.Length)
            {
                front++;
                elemen[front] = data;
                size++;
            } 
            else
            {
                Console.WriteLine("Stack is full");
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