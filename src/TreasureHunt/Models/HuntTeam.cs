using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    // phasing this one out...
    public class HuntTeam
    {
        public int HuntId { get; set; }
        [ForeignKey("HuntId")]
        public Hunt Hunt { get; set; }

        public int TeamId { get; set; }
        [ForeignKey("TeamId")]
        public Team Team { get; set; }

    }
}
