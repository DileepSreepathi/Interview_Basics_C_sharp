using System;
using System.Collections.Generic;
using System.Text;

namespace Interview_Basics_C_sharp
{

    //un sorted linked list
    class List_
    {

        Node head;

        class Node
        {

            public
              int data;
            public
              Node next;

            public

            Node(int d)
            {
                data = d;
                next = null;
            }
        }

        /* Function to remove duplicates from an
             unsorted linked list */
        void remove_duplicates()
        {
            Node ptr1 = null, ptr2 = null, dup = null;
            ptr1 = head;

            /* Pick elements one by one */
            while (ptr1 != null &&
                   ptr1.next != null)
            {
                ptr2 = ptr1;

                /* Compare the picked element with rest
                          of the elements */
                while (ptr2.next != null)
                {

                    /* If duplicate then delete it */
                    if (ptr1.data == ptr2.next.data)
                    {

                        /* sequence of steps is important here */
                        dup = ptr2.next;
                        ptr2.next = ptr2.next.next;

                    }
                    else /* This is tricky */
                    {
                        ptr2 = ptr2.next;
                    }
                }
                ptr1 = ptr1.next;
            }
        }

        void printList(Node node)
        {
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.next;
            }
        }

        // Driver Code
        public static void Main(String[] args)
        {
            List_ list = new List_();
            list.head = new Node(10);
            list.head.next = new Node(12);
            list.head.next.next = new Node(11);
            list.head.next.next.next = new Node(11);
            list.head.next.next.next.next = new Node(12);
            list.head.next.next.next.next.next = new Node(11);
            list.head.next.next.next.next.next.next = new Node(10);

            Console.WriteLine("Linked List_ before removing duplicates : \n ");
            list.printList(list.head);

            list.remove_duplicates();
            Console.WriteLine("");
            Console.WriteLine("Linked List_ after removing duplicates : \n ");
            list.printList(list.head);
        }
    }


    //sorted linked list :

    public class LinkedList
    {
        Node head; // head of list

        /* Linked list Node*/
        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d; next = null;
            }
        }

        void removeDuplicates()
        {
            /*Another reference to head*/
            Node current = head;

            /* Pointer to store the next 
            pointer of a node to be deleted*/
            Node next_next;

            /* do nothing if the list is empty */
            if (head == null)
                return;

            /* Traverse list till the last node */
            while (current.next != null)
            {

                /*Compare current node with the next node */
                if (current.data == current.next.data)
                {
                    next_next = current.next.next;
                    current.next = null;
                    current.next = next_next;
                }
                else // advance if no deletion
                    current = current.next;
            }
        }

        /* Utility functions */

        /* Inserts a new Node at front of the list. */
        public void push(int new_data)
        {
            /* 1 & 2: Allocate the Node &
                    Put in the data*/
            Node new_node = new Node(new_data);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
        }

        /* Function to print linked list */
        void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        /* Driver code */
        public static void Main(String[] args)
        {
            LinkedList llist = new LinkedList();
            llist.push(20);
            llist.push(13);
            llist.push(13);
            llist.push(11);
            llist.push(11);
            llist.push(11);

            Console.WriteLine("List before removal of duplicates");
            llist.printList();

            llist.removeDuplicates();

            Console.WriteLine("List after removal of elements");
            llist.printList();
        }
    }

}
