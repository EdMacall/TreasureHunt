using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    public class TeamClue
    {
        // appropriate to have Id here?
        public int Id { get; set; }

        public bool Solved { get; set; }
        public string TeamsAnswer { get; set; }

        // need to do something with Team or Clue here?
        public int TeamId { get; set; }
        [ForeignKey("TeamId")]
        public Team Team { get; set; }

        public int ClueId { get; set; }
        [ForeignKey("ClueId")]
        public Clue Clue { get; set; }
    }
}
