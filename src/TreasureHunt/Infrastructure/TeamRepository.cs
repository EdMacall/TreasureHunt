using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Infrastructure
{
    public class TeamRepository : GenericRepository<Team>
    {
        public TeamRepository(ApplicationDbContext db) : base(db) { }

        public IQueryable<Team> FindTeamsByHuntId(int id)
        {
            return from t in _db.Teams
                   where t.HuntId == id
                   select t;
        }

        public IQueryable<Team> FindUsersTeamById(int id, string currentUser)
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
