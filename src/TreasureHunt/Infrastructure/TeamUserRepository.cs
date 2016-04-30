using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Infrastructure
{
    public class TeamUserRepository : GenericRepository<TeamUser>
    {
        public TeamUserRepository(ApplicationDbContext db) : base(db) { }
    }
}
