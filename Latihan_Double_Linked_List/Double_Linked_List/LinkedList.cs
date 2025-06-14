using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Double_Linked_List
{
    public class LinkedList
    {
        private ListNode head;
        private int size;

        public LinkedList()
        {
            head = new ListNode();
            head.setNext(head);
            head.setPrev(head);
            size = 0;
        }

        public ListNode add_by_index(int index, int data)
        {
            ListNode pointer = head;
            for (int i = 0; i <= index; i++)
            {
                pointer = pointer.getNext();
            }

            return addBefore(data, pointer);
        }
        public ListNode update_element(int index, int data)
        {
            if (index <= getSize())
            {
                ListNode pointer = head;
                for (int i = 0; i <= index; i++)
                {
                    pointer = pointer.getNext();
                }
                pointer.setData(data);
                return pointer;

            }
            else
            {
                return null;
            }
        }
        public int indexof(int index)
        {
            if (index <= getSize())
            {
                ListNode pointer = head;
                for (int i = 0; i <= index; i++)
                {
                    pointer = pointer.getNext();
                }
                return pointer.getData();
            }
            else
            {
                return -1;
            }
        }

        public Boolean select_remove(int data)
        {
            ListNode pointer = head.getNext();
            while (pointer != head)
            {
                if (pointer.getData() == data)
                {
                    remove(pointer);
                    return true;
                }
                pointer = pointer.getNext();
            }
            return false;
        }

        public override string ToString()
        {
            string isi = "";
            ListNode pointer = head.getNext();
            while (pointer != head)
            {
                isi += (pointer.getData() + " ");
                pointer = pointer.getNext();
            }

            return isi;
        }

        public ListNode removeFirst()
        {
            return remove(head.getNext());
        }

        public ListNode removeLast()
        {
            return remove(head.getPrev());
        }
        public ListNode remove(ListNode item)
        {
            ListNode point = item;
            point.getPrev().setNext(point.getNext());
            point.getNext().setPrev(point.getPrev());
            return point;
        }
        public ListNode addFirst(int elemen)
        {
            return addBefore(elemen, head.getNext());
        }

        public ListNode addLast(int elemen)
        {
            return addBefore(elemen, head);
        }
// data pointer
        public ListNode addBefore(int elemen, ListNode bantu) 
        {
            ListNode baru = new ListNode(elemen);
            baru.setNext(bantu);
            baru.setPrev(bantu.getPrev());
            bantu.setPrev(baru);
            baru.getPrev().setNext(baru);
            size++;
            return baru;

        }

        public Boolean isEmpty()
        {
            if (getSize() == 0)
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
        public ListNode getHead()
        {
            return this.head;
        }

        public void setHead(ListNode head)
        {
            this.head = head;
        }

    }
}