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
        private ClueRepository _cluerepository;
        private ApplicationUserRepository _userrepository;

        public TeamService(TeamRepository teamrepository, ClueRepository cluerepository, ApplicationUserRepository userrepository)
        {
            _userrepository = userrepository;
            _teamrepository = teamrepository;
            _cluerepository = cluerepository;
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

        public TeamDTO GetUsersTeam(int id, string currentUser)
        {
            TeamDTO team = (from t in _teamrepository.FindUsersTeamById(id, currentUser)
                            select new TeamDTO
                            {
                                Name = t.Name,
                                ImageURL = t.ImageURL,
                                Points = t.Points
                            }).FirstOrDefault();

            team.Clues = (from c in _cluerepository.FindCluesByTeamId(id)
                          select new ClueDTO {
                              Id = c.Id,
                              Title = c.Title,
                              Description = c.Description,
                              PointValue = c.PointValue
                          }
                         ).ToList();

            return team;
        }

       
        public TeamDTO GetTeam(int id)
        {
            TeamDTO team = (from t in _teamrepository.FindTeamById(id)
                            select new TeamDTO
                            {
                                Name = t.Name,
                                ImageURL = t.ImageURL,
                                Points = t.Points
                            }).FirstOrDefault();



            return team;
        }

        public void JoinTeam(string teamName, string currentUser)
        {
            // ApplicationUserDTO user = _userrepository.FindUserById()

            ApplicationUser user = _userrepository.FindUserByName(currentUser).FirstOrDefault();

            ApplicationUserDTO userdto = new ApplicationUserDTO
            {
                Email = user.Email,
                UserName = user.UserName,
                ImageURL = user.ImageURL
            };
        }

        public TeamDTO GetTeamByName(string name)
        {
            TeamDTO team = (from t in _teamrepository.FindTeamByName(name)
                            select new TeamDTO
                            {
                                Name = t.Name,
                                ImageURL = t.ImageURL,
                                Points = t.Points
                            }
                            ).FirstOrDefault();
            return team;
        }
        

        public ICollection<TeamDTO> GetTeamsWithHuntId(int id)
        {
            return (from t in _teamrepository.FindTeamsByHuntId(id)
                    select new TeamDTO
                    {
                        Name = t.Name,
                        ImageURL = t.ImageURL,
                        Points = t.Points
                    }).ToList();
        }

        public void AddTeam(TeamDTO teamdto, int huntId)
        {
            Team team = new Team
            {
                Name = teamdto.Name,
                ImageURL = teamdto.ImageURL,
                Points = teamdto.Points,
                HuntId = huntId
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
