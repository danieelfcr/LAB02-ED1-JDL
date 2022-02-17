using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibrary
{
    public class GenericList<T>
    {
        T First;
        T Last;

        public bool Insertion(T newPlayer)
        {
            if (First == null)
            {
                First = newPlayer;
                Last = First;
                return true;
            }
            else
            {
                T aux = First;

                while(!EqualityComparer<T>.Default.Equals(aux, Last))
                {
                    if (aux == null)
                    {
                        aux = newPlayer;
                        Last = aux;
                        
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
