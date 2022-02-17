using LAB02_ED1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB02_ED1.Helpers
{
    public class DataTeam
    {
        private static DataTeam _instance = null;

        public static DataTeam Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataTeam();
                }
                return _instance;
            }
        }




        public List<TeamModel> Teamlist = new List<TeamModel>
        {

        };
    }
}
