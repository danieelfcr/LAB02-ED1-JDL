using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary01
{
    public class Node<T>
    {
        public Node<T> next;
        public Node<T> previous;
        public T Data;
        public int NodeID;

        public Node(T Data)
        {
            this.Data = Data;
        }
    }
}
