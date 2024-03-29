﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    public class Hunt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Story { get; set; }
        public string ImageURL { get; set; }

        public ICollection<Team> Teams { get; set; }
        public ICollection<Clue> Clues { get; set; }
    }
}
