using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Infrastructure;
using TreasureHunt.Models;
using TreasureHunt.Services.Models;

namespace TreasureHunt.Services
{
    public class TeamService
    {
        private TeamRepository _teamrepository;
        private HuntTeamRepository _huntTeamRepo;

        public TeamService(TeamRepository teamrepository, HuntTeamRepository huntTeamRepo)
        {
            _teamrepository = teamrepository;
            _huntTeamRepo = huntTeamRepo;
        }

        public ICollection<TeamDTO> GetTeamList()
        {
            return (from t in _teamrepository.List()
                    select new TeamDTO
                    {
                        Name = t.Name,
                        // ApplicationUsers = t.ApplicationUsers,
                        // Riddles = t.Riddles
                    }).ToList();
        }

        public TeamDTO GetTeam(int id)
        {
            // return _huntrepository.First(b => b.Id ==id);

            Team team = _teamrepository.List().FirstOrDefault(m => m.Id == id);

            return new TeamDTO { Name = team.Name,
            Points = team.Points};
        }

        public void AddTeamList(TeamDTO teamdto)
        {
            Team team = new Team
            {
                Name = teamdto.Name
            };

            _teamrepository.Add(team);
            _teamrepository.SaveChanges();

        }

        public TeamDTO AddHuntTeamList(int huntId, TeamDTO teamdto)
        {

            Team team = new Team
            {
                Name = teamdto.Name
            };

            _teamrepository.Add(team);
            _teamrepository.SaveChanges();

            _huntTeamRepo.Add(new HuntTeam()
            {
                HuntId = huntId,
                TeamId = team.Id
            });
            _huntTeamRepo.SaveChanges();

            return new TeamDTO() {
                Name = team.Name
            };
        }
    }
}
