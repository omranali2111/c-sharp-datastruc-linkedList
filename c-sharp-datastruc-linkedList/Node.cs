using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_datastruc_linkedList
{
    internal class Node
    {
        public int data;
        public Node Next;

        public Node(int data)
        {
            this.data = data;
        }

        public Node(int data, Node Next) 
        {
            this.data = data;
             Next=null;
        }
    }
}
