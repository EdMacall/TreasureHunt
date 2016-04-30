using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Infrastructure;
using TreasureHunt.Models;
using TreasureHunt.Services.Models;

namespace TreasureHunt.Services
{
    // phasing this one out...
    public class HuntTeamService
    {
        private HuntTeamRepository _huntteamrepository;

        public HuntTeamService(HuntTeamRepository huntteamrepository)
        {
            _huntteamrepository = huntteamrepository;
        }

        public ICollection<HuntTeamDTO> GetHuntTeamList()
        {
            return (from r in _huntteamrepository.List()
                    select new HuntTeamDTO
                    {
                        // TeamName =
                    }).ToList();
        }

        public ICollection<HuntTeamDTO> GetHuntTeamList(int id)
        { 
        /*
        public ICollection<TeamDTO> GetHuntTeamList(int id)
        {
            Hunt hunt = (from ht in _huntteamrepository.List()
                         where ht.HuntId == id
                         select ht.Hunt).FirstOrDefault();
            return hunt.Teams.Cast<TeamDTO>().ToList();
            */
            return  (from ht in _huntteamrepository.List()
                     where ht.HuntId == id
                     select new HuntTeamDTO
                     {
                         TeamName = ht.Team.Name
                     }).ToList();
        }

        public HuntDTO GetTeamHuntList(int id)
        {
            Hunt hunt = (from tm in _huntteamrepository.List()
                         where tm.TeamId == id
                         select tm.Hunt).FirstOrDefault();
            HuntDTO huntdto = new HuntDTO { Name = hunt.Name };
            return huntdto;
 
        }

        public void AddHuntTeam(int huntId, int teamId)
        {
            HuntTeam huntteam = new HuntTeam
            {
                HuntId = huntId,
                TeamId = teamId
            };
            _huntteamrepository.Add(huntteam);
            _huntteamrepository.SaveChanges();
        }
    }
}
