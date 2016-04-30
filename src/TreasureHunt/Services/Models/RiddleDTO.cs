using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Services.Models
{
    // phasing this one out...
    public class RiddleDTO
    {
        public string Title { get; set; }
        public string Clue { get; set; }
        public string Answer { get; set; }
        public bool IsAnswered { get; set; }
        public string Completed { get; set; }
        public int Points { get; set; }
    }
}
