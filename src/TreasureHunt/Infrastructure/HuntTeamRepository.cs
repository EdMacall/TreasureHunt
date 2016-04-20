using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Infrastructure
{
    public class HuntTeamRepository : GenericRepository<HuntTeam>
    {
        public HuntTeamRepository(ApplicationDbContext db) : base(db) { }
    }
}
