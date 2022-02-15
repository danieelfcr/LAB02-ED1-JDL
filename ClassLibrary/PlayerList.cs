using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class PlayerList<T>
    {
        Player<T> First;
        Player<T> Last;

        public bool Insertion(Player<T> newPlayer)
        {
            if (First == null)
            {
                First = newPlayer;
                Last = First;
                return true;
            }
            else
            {
                Player<T> aux = First;

                while(aux != Last)
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
