using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_datastruc_linkedList
{
    public class linklist
    {
        private Node head;

        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }

        }

        public void Remove(int data)
        {
            if (head == null)
            {
                Console.WriteLine("where is no node");
                return;
            }
            else
            { 
                if(head.data== data)
                {
                    head = head.Next;
                }
                else
                {
                    Node currentNode = head;
                    Node prevNode = null;
                    while (currentNode.Next != null&& currentNode.data!=data)
                    {
                        prevNode = currentNode;
                        currentNode = currentNode.Next;
                    }
                    if(currentNode==null)
                    {
                        Console.WriteLine("data not found");
                        return;
                        
                    }
                    prevNode.Next = currentNode.Next;
                }
            }
           

        }

        public void addInPosition(int data,int prevdata)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                // If the list is empty, make the new node the head
                head = newNode;
            }
            else
            {
                Node currentNode = head;

                while (currentNode != null && currentNode.data != prevdata)
                {
                    currentNode = currentNode.Next;
                }

                if (currentNode != null)
                {
                    newNode.Next = currentNode.Next;
                    currentNode.Next = newNode;
                }
                else
                {
                    // Node with prevdata not found
                    Console.WriteLine("Node not found!");
                   
                }
            }

        }
        public void insertAtPosition(int data, int position)
        {
            Node newNode = new Node(data);
            
            if (position == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                int currentPosition = 0;
                Node prevNode = null;

                while (currentNode != null && currentPosition < position)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.Next;
                    currentPosition++;
                }
                prevNode.Next = newNode;
                newNode.Next = currentNode;

            }

        }
        public int Find(int data)
        {
            Node currentNode = head;
            int position = 0;

            while (currentNode != null)
            {
                if (currentNode.data == data)
                {
                    Console.Write($"the posposition of node contain data {data} is: ");
                    return position;
                }

                currentNode = currentNode.Next;
                position++;
            }

            return -1; // Data not found
        



    }
        public void Print()
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                Console.Write(currentNode.data + " ");
                currentNode = currentNode.Next;
            }
            Console.WriteLine();
        }
    }
}


    





        

