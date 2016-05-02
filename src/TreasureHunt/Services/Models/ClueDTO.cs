using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Services.Models
{
    public class ClueDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; }
        public int PointValue { get; set; }

        // should this be a TeamDTO
        public ICollection<TeamDTO> Teams { get; set; }
    }
}
