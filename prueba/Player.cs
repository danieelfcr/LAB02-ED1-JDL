using System;

namespace ClassLibrary
{
    public class Player<T>
    {
       
        private string Name { get; set; }
        private string LastName { get; set; }
        private string Role { get; set; }
        private double KDA { get; set; }
        private int CreepScore { get; set; }
        private string Team { get; set; }

        public Player<T> Previous;
        public Player<T> Next;
       
    }
}
