﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Services.Models
{
    public class TeamDTO
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public int Points { get; set; }

        public ICollection<ApplicationUserDTO> ApplicationUsers { get; set; }
        public ICollection<ClueDTO> Clues { get; set; }
    }
}
