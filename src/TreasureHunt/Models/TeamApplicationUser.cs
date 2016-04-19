using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    public class TeamApplicationUser
    {
        [ForeignKey("TeamId")]
        public int TeamId { get; set; }
        public Team Team { get; set; }

        [ForeignKey("ApplicationUserId")]
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
