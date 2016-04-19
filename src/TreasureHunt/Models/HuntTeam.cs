using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    public class HuntTeam
    {
        [ForeignKey("HuntId")]
        public int HuntId { get; set; }
        public Hunt Hunt { get; set; }

        [ForeignKey("TeamId")]
        public int TeamId { get; set; }
        public Team Team { get; set; }

    }
}
