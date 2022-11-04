using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day14_Assingment
{
    public class linklist1
    {
        public Node front;
        public Node rear;

        public class Node
        {
            public int data;
            public Node next;

            // Constructor to create a new node.Next is by default initialized as null 
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }


        public class LinkListQueue
        {

            public Node front;
            public Node rear;
            //Node front;
            //Node rear;

            public LinkListQueue()
            {
                this.front = this.rear = null;
            }
        }

        public void Enqueue(int item)
        {

            Node newNode = new Node(item);

            // If queue is empty, then new node is front and rear both 
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                // Add the new node at the end of queue and change rear 
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine("{0} inserted into Queue", item);
        }

        internal void Dequeue()
        {
            // If queue is empty, return NULL. 
            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            // Store previous front and move front one node ahead 
            Node temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL, then change rear also as NULL 
            if (this.front == null)
            {
                this.rear = null;
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }


    }
   
}
