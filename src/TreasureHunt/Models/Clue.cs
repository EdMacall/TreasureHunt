using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    public class Clue
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; }
        public int PointValue { get; set; }

        public ICollection<TeamClue> TeamClues { get; set; }

        public int HuntId { get; set; }
        [ForeignKey("HuntId")]
        public Hunt Hunt { get; set; }
    }
}
