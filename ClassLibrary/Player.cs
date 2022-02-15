using System;

namespace ClassLibrary
{
    public class Player<T>
    {
       
        private string Name;
        private string LastName;
        private string Role;
        private double KDA;
        private int CreepScore;
        private string Team;

        public Player<T> Previous;
        public Player<T> Next;
       
    }
}
