using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
       public DLList() { head = null;  tail = null; } // constructor
        /*-------------------------------------------------------------------
        * The methods below includes several errors. Your  task is to write
        * unit test to discover these errors. During delivery the tutor may
        * add or remove errors to adjust the scale of the effort required by
        */
        public void addToTail(DLLNode p)
        {
            //if the list is empty
            if (head == null)
            {
                //head and tail pointers to the new node
                head = p;
                tail = p;
            }
            //if the list is not empty
            else
            {
                //update nodes with new added node
                tail.next = p;
                p.previous = tail;
                tail = p;
            }
        } // end of addToTail
        public void addToHead(DLLNode p)
        {
            //if the list is empty
            if (head == null)
            {
                //head and tail pointers to new node
                head = p;
                tail = p;
            }
            //if the list is not empty
            else
            {
                //update nodes with new added node
                p.next = head;
                head.previous = p;
                head = p;
            }
        } // end of addToHead
        public void removeHead()
        {
            //if list is empty
            if (head == null)
            {
                return;
            }
            //if list has 1 node
            if (head == tail)
            {
                //make it null
                head = null;
                tail = null;
            }
            //if list has more than 1 node
            else
            {
                //update head pointer, remove head
                head = head.next;
                head.previous = null;
            }
        } // end of removeHead
        public void removeTail()
        {
            //if list is empty
            if (tail == null)
            {
                return;
            }
            //if list has 1 node
            if (head == tail)
            {
                //remove node
                head = null;
                tail = null;
            }
            //if list has more than 1 node
            else
            {
                //update node previous, remove tail node.
                tail = tail.previous;
                tail.next = null;
            }
        } // end of removeTail
        public DLLNode search(int num)
        {
            //start of list
            DLLNode p = head;
            //loop till end of list, or node found
            while (p != null && p.num != num)
            {
                //move to next node
                p = p.next;
            }
            //return node or null if not found
            return p;
        } // end of search;
        public void removeNode(DLLNode p)
        {
            //if p is tail node
            if (p.next == null)
            {
                //move tail to previous, remove old tail
                tail = tail.previous;
                tail.next = null;
            }
            //if p is the head node
            else if (p.previous == null)
            {
                //move head to next, remove old head
                head = head.next;
                head.previous = null;
            }
            //if p is neither head or tail node
            else
            {
                //update pointers of previous and next nodes of p
                p.next.previous = p.previous;
                p.previous.next = p.next;
            }
            //remove p
            p.next = null;
            p.previous = null;
        } // end of remove a node
        public int total()
        {
            DLLNode p = head;
            int tot = 0;
            //iterate through list until end
            while (p != null)
            {
                //add value of current node to total and move to next node.
                tot += p.num;
                p = p.next;
            }
            return tot;
        } // end of total
    } // end of DLList class
}
