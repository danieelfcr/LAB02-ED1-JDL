
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LAB02_ED1.Models
{
    public class TeamModel
    {
        [Required]
        [MaxLength(15)]
        public string TeamName { get; set; }
        [Required]
        [MaxLength(15)]
        public string Coach { get; set; }

        [Required]
        public string League { get; set; }
        [Required]
        public DateTime DateCreation { get; set; }
        


        
    }
}
