using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Single_Linked_List
{
    public class ListNode
    {
        private int data;

        private ListNode next;

        public ListNode(int data)
        {
            this.data = data;
            this.next = null;
        }
        public int getData()
        {
            return this.data;
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
            this.next  = next;
        }
    }
}