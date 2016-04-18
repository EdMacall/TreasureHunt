using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Infrastructure
{
    public class TeamRepository : GenericRepository <Team>
    {
        public TeamRepository(ApplicationDbContext db) : base(db) {}
    }
}
