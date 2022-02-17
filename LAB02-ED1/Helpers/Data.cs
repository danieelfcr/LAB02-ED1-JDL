
using ClassLibrary01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LAB02_ED1.Helpers
{
    public class Data
    {
        private static Data _instance = null;

        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }




        public GenericList<Player> Playerlist = new GenericList<Player>();
        
       
       // Player newPlayer = new Player("James", "Clare", "Coach", 13.44, 57, "si");
        
       
    }
}
