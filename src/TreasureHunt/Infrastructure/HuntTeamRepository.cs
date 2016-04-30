using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Infrastructure
{
    // phasing this one out...
    public class HuntTeamRepository : GenericRepository<HuntTeam>
    {
        public HuntTeamRepository(ApplicationDbContext db) : base(db) { }
    }
}
