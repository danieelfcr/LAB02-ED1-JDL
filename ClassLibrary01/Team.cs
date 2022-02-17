using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary01
{
    public class Team<T>
    {
        
        private string TeamName;
        private string Coach;
        private string League;
        private DateTime CreationDate;

        public Team<T> Previous;
        public Team<T> Next;
    }
}
