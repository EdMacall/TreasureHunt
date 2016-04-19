using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Infrastructure;
using TreasureHunt.Services.Models;

namespace TreasureHunt.Services
{
    public class TeamService
    {
        private TeamRepository _teamrepository;

        public TeamService(TeamRepository teamrepository)
        {
            _teamrepository = teamrepository;
        }

        public ICollection<TeamDTO> GetTeamList()
        {
            return (from t in _teamrepository.List()
                    select new TeamDTO
                    {
                        Name = t.Name,
                        ApplicationUsers = t.ApplicationUsers,
                        Riddles = t.Riddles
                    }).ToList();
        }
    }
}
