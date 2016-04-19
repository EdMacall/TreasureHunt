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

        
        public int? HuntId { get; set; }
        [ForeignKey("HuntId")]
        public Hunt Hunt { get; set; }
        

        public string Story { get; set; }
        public string Picture { get; set; }
        public int FirstClueId { get; set; }
        public int NumRiddles { get; set; }
    }
}
