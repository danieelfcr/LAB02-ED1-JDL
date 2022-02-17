using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary01
{
    public class Player: IEnumerable
    {

        public Player(string Name, string LastName, string Role, double KDA, int CreepScore, string Team)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Role = Role;
            this.KDA = KDA;
            this.CreepScore = CreepScore;
            this.Team = Team;
            this.Previous = null;
            this.Next = null;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public double KDA { get; set; }
        public int CreepScore { get; set; }
        public string Team { get; set; }

        public Player Previous;
        public Player Next;

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
