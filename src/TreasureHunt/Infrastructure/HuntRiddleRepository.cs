using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Infrastructure
{
    // phasing this one out...
    public class HuntRiddleRepository : GenericRepository<HuntRiddle>
    {
        public HuntRiddleRepository(ApplicationDbContext db) : base(db) { }
    }
}
