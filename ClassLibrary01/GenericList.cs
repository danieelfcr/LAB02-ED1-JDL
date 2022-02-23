using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace ClassLibrary01
{
    public class GenericList<T>: IGenericList<T>, IEnumerable<T>
    {
        private static GenericList<T> PlayerInstance;
        private static GenericList<T> TeamInstance;

        public static GenericList<T> GetInstance
        {
            get
            {
                if (typeof(T) == typeof(Player))
                {
                    if (PlayerInstance == null)
                    {
                        PlayerInstance = new GenericList<T>();
                        return PlayerInstance;
                    }
                    return PlayerInstance;
                }
                if (typeof(T) == typeof(Team))
                {
                    if (TeamInstance == null)
                    {
                        TeamInstance = new GenericList<T>();
                        return TeamInstance;
                    }
                    return TeamInstance;
                }
                return PlayerInstance;
            }
        }

        public Node<T> Head
        {
            get
            {
                return First;
            }
        }

        private Node<T> First;
        private Node<T> Last;
        public int n = 0;

        public void Insert(Node<T> node)
        {
            
            if (First == null)
            {
                First = node;
                First.next = null;
                First.previous = null;
                Last = First;
                n++;
            }
            else
            {
                Last.next = node;
                node.next = null;
                node.previous = Last;
                Last = node;
                n++;
            }
            
        }

        

        public Node<T> Find(int ID)
        {
            var Node = First;
            while (Node != null)
            {
                var aux = Node;
                Node = Node.next;
                if (aux.NodeID == ID)
                {
                    return aux;
                } 
            }
            return null;
        }


        public void Delete(int ID)
        {
            var Node = First;
            while (Node != null)
            { 
                if (Node.NodeID == ID)
                {
                    if (Node == First)
                    {
                        First = First.next;
                    }
                    else if (Node == Last)
                    {
                        Last = Last.previous;
                        Last.next = null;
                    }
                    else
                    {
                        Node.previous.next = Node.next;
                        Node.next.previous = Node.previous;
                    }
                }
                Node = Node.next;
            }
        }

        public void Edit(int id, Node<T> model)
        {
            var Node = First;
            while (Node != null)
            {
                if (Node.NodeID == id)
                {
                    model.next = Node.next;
                    model.previous = Node.previous;
                    Node = model;
                    break;
                }
                Node = Node.next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var Node = First;
            while (Node != null)
            {
                var aux = Node;
                Node = Node.next;
                yield return aux.Data;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

      
    }
}
