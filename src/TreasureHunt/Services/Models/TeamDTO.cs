using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Services.Models
{
    public class TeamDTO
    {
        public string Name { get; set; }
        public int Hunt { get; set; }
        // public string Hunt { get; set; }
        public string Story { get; set; }
        // public string Picture { get; set; }
        // public string FirstClue { get; set; }
        public int NumRiddles { get; set; }
    }
}
