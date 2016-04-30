﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    // phasing this one out...
    public class TeamRiddle
    {
        public int TeamId { get; set; }
        [ForeignKey("TeamId")]
        public Team Team { get; set; }

        public int RiddleId { get; set; }
        [ForeignKey("RiddleId")]
        public Riddle Riddle { get; set; }
    }
}
