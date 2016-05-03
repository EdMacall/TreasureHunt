using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Infrastructure
{
    public class HuntRepository : GenericRepository<Hunt>
    {
        public HuntRepository(ApplicationDbContext db) : base(db) { }

        public IQueryable<Hunt> FindHuntById(int id)
        {
            return from h in _db.Hunts
                   where h.Id == id
                   select h;
        }
    }

}
