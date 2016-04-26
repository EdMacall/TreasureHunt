using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Services.Models
{
    public class RiddleDTO
    {
        public string Clue { get; set; }
        public string Answer { get; set; }
        public bool IsAnswered { get; set; }
        public int Points { get; set; }
    }
}
