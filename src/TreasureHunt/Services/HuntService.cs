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
        private ClueRepository _cluerepository;

        public HuntService(HuntRepository huntrepository,
                           TeamRepository teamrepository,
                           ClueRepository cluerepository)
        {
            _huntrepository = huntrepository;
            _teamrepository = teamrepository;
            _cluerepository = cluerepository;
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
            Hunt hunt = _huntrepository.List().FirstOrDefault(m => m.Id == id);

            // Team team = _teamrepository.List().

            // Clue clue

            return new HuntDTO
            {
                Id = hunt.Id,
                Story = hunt.Story,
                Name = hunt.Name,
                ImageURL = hunt.ImageURL
            };
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
