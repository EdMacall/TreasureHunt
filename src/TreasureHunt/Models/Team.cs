using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public int Points { get; set; }

        public int HuntId { get; set; }
        [ForeignKey("HuntId")]
        public Hunt Hunt { get; set; }

        public ICollection<TeamClue> TeamClues { get; set; }
        public ICollection<TeamUser> TeamUsers { get; set; }

    }
}
