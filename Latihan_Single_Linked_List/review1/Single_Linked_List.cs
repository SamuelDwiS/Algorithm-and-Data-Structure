using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamuelDwi_Single_Linked_List
{
    public class Single_Linked_List
    {
        private ListNode firstNode;

        private ListNode lastNode;

        private int size;

        public Single_Linked_List()
        {
            firstNode = null;
            lastNode = null;
            this.size = 0;
        }

        public void addFirst(int data)
        {
            ListNode bantu = new ListNode(data);
            if(isEmpty())
            {
                firstNode = lastNode = bantu;
            } else 
            {
                bantu.setNext (firstNode);
                firstNode = bantu;
            }
            size++;
        }

        public void addLast(int data)
        {
            ListNode bantu = new ListNode(data);
            if(isEmpty())
            {
                firstNode = lastNode = bantu;
            }else
            {
                lastNode.setNext(bantu);
                lastNode = bantu;
            }
            size ++;
        }

        public ListNode removeFirst()
        {
            ListNode bantu = null;
            if(!isEmpty())
            {
                bantu = firstNode;
                firstNode = firstNode.getNext();
                bantu.setNext(null);
                size --;
            }
            return bantu;
        }

        public ListNode removeLast()
        {
            ListNode bantu = firstNode;
            if(!isEmpty())
            {
                if(firstNode == lastNode)
                {
                    bantu = firstNode;
                    firstNode = lastNode = bantu;
                } 
                else 
                {
                    while(bantu.getNext() != lastNode)
                    {
                        bantu = bantu.getNext();
                    }
                    lastNode = bantu;
                    bantu = bantu.getNext();
                    lastNode.setNext(null);
                }
                size --;
            }

            return bantu;
        }

        public override string ToString()
        {
            string isi ="";
            ListNode pointer = firstNode;
            while(pointer != null)
            {
                isi += pointer.getData() +" ";
                pointer = pointer.getNext();
            }

            return isi;
        }

        public Boolean isEmpty()
        {
            if(firstNode == null && lastNode == null)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public ListNode getFirstNode()
        {
            return firstNode;
        }

        public void setFirstNode(ListNode node)
        {
            firstNode = node;
        }

        public ListNode getLastNode()
        {
            return lastNode;
        }

        public void setLastNode(ListNode node)
        {
            lastNode = node;
        }

        public int getSize()
        {
            return size;
        }

        public void setSize(int size)
        {
            this.size = size;
        }

    }
}