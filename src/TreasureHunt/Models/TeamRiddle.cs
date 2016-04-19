using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    public class TeamRiddle
    {
        [ForeignKey("TeamId")]
        public int TeamId { get; set; }
        public Team Team { get; set; }

        [ForeignKey("RiddleId")]
        public int RiddleId { get; set; }
        public Riddle Riddle { get; set; }
    }
}
