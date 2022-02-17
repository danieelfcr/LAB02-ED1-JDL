using LAB02_ED1.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LAB02_ED1.Models
{
    public class PlayerModel
    {
        [Required]
        [MaxLength(15)]
        public string Name { get; set; }
        [Required]
        [MaxLength(15)]
        public string LastName { get; set; }

        [Required]
        public string Role { get; set; }
        [Required]
        public double KDA { get; set; }
        [Required]
        public int CreepScore { get; set; }
        [Required]
        public string Team { get; set; }




        public static void Save(PlayerModel model)
        {
            Data.Instance.Playerlist.Add(model);
        }

    }
}
