﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Infrastructure
{
    public class ClueRepository : GenericRepository<Clue>
    {
        public ClueRepository(ApplicationDbContext db) : base(db) { }
    }
}