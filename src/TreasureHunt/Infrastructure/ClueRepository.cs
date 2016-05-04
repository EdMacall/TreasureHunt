using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Infrastructure
{
    public class ClueRepository : GenericRepository<Clue>
    {
        public ClueRepository(ApplicationDbContext db) : base(db) { }

        public IQueryable<Clue> FindCluesByTeamId(int id)
        {
            return from c in _db.Clues
                   where c.Id == id
                   select c;
        }

        public IQueryable<Team> FindUsersClueById(int id, string currentUser)
        {
            return from t in _db.Teams
                   where t.Id == id && t.TeamUsers.Any(tu => tu.ApplicationUser.UserName == currentUser)
                   select t;
        }

        public IQueryable<Team> FindTeamById(int id)
        {
            return from t in _db.Teams
                   where t.Id == id
                   select t;
        }
    }
}
