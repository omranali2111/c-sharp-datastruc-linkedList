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


    





        

