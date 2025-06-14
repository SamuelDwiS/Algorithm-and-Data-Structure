using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Double_Linked_List
{
    public class ListNode
    {
        private int data;
        private ListNode next;
        private ListNode prev;

        public ListNode()
        {
            
        }
        
        public ListNode(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }


        public int getData()
        {
            return data;
        }
        public void setData(int data)
        {
            this.data = data;
        }

        public ListNode getNext()
        {
            return this.next;
        }
        public void setNext(ListNode next)
        {
            this.next = next;
        }

        public ListNode getPrev()
        {
            return this.prev;
        }
        public void setPrev(ListNode prev)
        {
            this.prev = prev;
        }
    }
}