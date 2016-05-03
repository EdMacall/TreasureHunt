using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Infrastructure;
using TreasureHunt.Models;
using TreasureHunt.Services.Models;

namespace TreasureHunt.Services
{
    public class HuntService
    {
        private HuntRepository _huntrepository;
        private TeamRepository _teamrepository;
        private TeamService    _teamservice;
        private ClueRepository _cluerepository;

        public HuntService(HuntRepository huntrepository,
                           TeamRepository teamrepository,
                           TeamService    teamservice,
                           ClueRepository cluerepository
                           )
        {
            _huntrepository = huntrepository;
            _teamrepository = teamrepository;
            _cluerepository = cluerepository;
            _teamservice    = teamservice;
        }

        public ICollection<HuntDTO> GetHuntList()
        {
            return (from h in _huntrepository.List()
                    select new HuntDTO
                    {
                        Id = h.Id,
                        Story = h.Story,
                        Name = h.Name,
                        ImageURL = h.ImageURL
                    }).ToList();
        }

        public HuntDTO GetHunt(int id)
        {
            HuntDTO hunt = (from h in _huntrepository.FindHuntById(id)
                            select new HuntDTO
                            {
                                Id = h.Id,
                                Story = h.Story,
                                Name = h.Name,
                                ImageURL = h.ImageURL
                            }).FirstOrDefault();

            hunt.Teams = _teamservice.GetTeamsWithHuntId(id);

            return hunt;
        }

        public void AddHuntList(HuntDTO huntdto)
        {
            Hunt hunt = new Hunt
            {
                Name = huntdto.Name
            };
            _huntrepository.Add(hunt);
            _huntrepository.SaveChanges();
        }

    }
}
