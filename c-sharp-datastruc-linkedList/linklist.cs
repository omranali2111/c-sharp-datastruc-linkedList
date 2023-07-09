using System;
using System.Collections.Generic;
using System.Linq;
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


    





        

