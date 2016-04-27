using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Services.Models
{
    public class TeamDTO
    {
        public string Name { get; set; }
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public ICollection<Riddle> Riddles { get; set; }
        public int Points { get; set; }
    }
}
