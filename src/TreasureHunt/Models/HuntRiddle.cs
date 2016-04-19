using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    public class HuntRiddle
    {
        [ForeignKey("HuntId")]
        public int HuntId { get; set; }
        public Hunt Hunt { get; set; }

        [ForeignKey("RiddleId")]
        public int RiddleId { get; set; }
        public Riddle Riddle { get; set; }
    }
}
