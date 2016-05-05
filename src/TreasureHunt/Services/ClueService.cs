using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Infrastructure;
using TreasureHunt.Models;
using TreasureHunt.Services.Models;

namespace TreasureHunt.Services
{
    public class ClueService
    {
        private ClueRepository _cluerepository;

        public ClueService(ClueRepository cluerepository)
        {
            _cluerepository = cluerepository;
        }

        public ICollection<ClueDTO> GetClueList()
        {
            return (from c in _cluerepository.List()
                    select new ClueDTO
                    {
                        // is it appropriate to have Id here?
                        Id = c.Id,
                        Title = c.Title,
                        Description = c.Description,
                        // Answer = c.Answer,
                        PointValue = c.PointValue
                    }).ToList();
        }

        public ClueDTO GetClue(int id)
        {
            Clue clue = _cluerepository.List().FirstOrDefault(m => m.Id == id);

            return new ClueDTO {
                Id = clue.Id,
                Title = clue.Title,
                Description = clue.Description,
                // Answer = clue.Answer,
                PointValue = clue.PointValue
            };
        }

        public void SaveChanges()
        {
            _cluerepository.SaveChanges();
        }
    }
}
