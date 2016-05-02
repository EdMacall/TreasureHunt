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
                        ImageURL = t.ImageURL,
                        Points = t.Points,
                        // ApplicationUsers = t.ApplicationUsers,
                        // Clues = t.Clues
                    }).ToList();
        }

        public TeamDTO GetTeam(int id)
        {
            Team team = _teamrepository.List().FirstOrDefault(m => m.Id == id);

            return new TeamDTO
            {
                Name = team.Name,
                ImageURL = team.ImageURL,
                Points = team.Points,
                // ApplicationUsers = team.ApplicationUsers,
                // Clues = team.Clues
            };
        }

        public void AddTeamList(TeamDTO teamdto)
        {
            Team team = new Team
            {
                Name = teamdto.Name,
                ImageURL = teamdto.ImageURL,
                Points = teamdto.Points,
                // ApplicationUsers = teamdto.ApplicationUsers,
                // Clues = teamdto.Clues
            };

            _teamrepository.Add(team);
            _teamrepository.SaveChanges();

        }

        /*
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
        */
    }
}
