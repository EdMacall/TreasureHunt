using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    public class Riddle
    {
        public int Id { get; set; }
        public string Clue { get; set; }
        public string Answer { get; set; }
        public bool IsAnswered { get; set; }

    }
}
