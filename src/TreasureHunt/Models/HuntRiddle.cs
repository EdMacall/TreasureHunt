using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    // phasing this one out...
    public class HuntRiddle
    {
        public int HuntId { get; set; }
        [ForeignKey("HuntId")]
        public Hunt Hunt { get; set; }

        public int RiddleId { get; set; }
        [ForeignKey("RiddleId")]
        public Riddle Riddle { get; set; }
    }
}
