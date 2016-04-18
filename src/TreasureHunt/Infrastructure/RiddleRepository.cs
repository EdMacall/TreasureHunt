using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Infrastructure
{
    public class RiddleRepository : GenericRepository<Riddle>
    {
        public RiddleRepository(ApplicationDbContext db) : base(db) { }
    }
}
