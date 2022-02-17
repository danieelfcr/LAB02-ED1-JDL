using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace ClassLibrary01
{
    public class GenericList<T>: IGenericList<T>, IEnumerable<T> where T: Player
    {
        T First;
        T Last;
        int count;

        
        public bool Insert(T newElement)
        {
            if (First == null)
            {
                First = newElement;
                First.Next = null;
                First.Previous = null;
                Last = First;
                return true;
            }
            else
            {
                Last.Next = newElement;
                newElement.Next = null;
                newElement.Previous = Last;
                Last = newElement;

                //!EqualityComparer<T>.Default.Equals(aux, Last)
                /*
                while (aux != Last)
                {
                    if (aux == null)
                    {
                        aux = newElement;
                        Last = aux;
                        
                        return true;
                    }
                }*/
            }
            return false;
        }

        public bool Delete(int index)
        {
            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            Player node = First;
            while (node != null)
            {
                yield return node.Name;
                yield return node.LastName;
                yield return node.Role;
                yield return node.KDA;
                yield return node.CreepScore;
                yield return node.Team;
                node = node.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
