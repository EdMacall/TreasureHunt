﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Infrastructure
{
    public class TeamClueRepository : GenericRepository<TeamClue>
    {
        public TeamClueRepository(ApplicationDbContext db) : base(db) { }
    }
}
