﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreasureHunt.Services.Models
{
    public class HuntDTO
    {
        // appropriate to have Id here?
        public int Id { get; set; }

        public string Name { get; set; }
        public string Story { get; set; }
        public string ImageURL { get; set; }

        public ICollection<TeamDTO> Teams { get; set; }
        public ICollection<ClueDTO> Clues { get; set; }
    }
}
