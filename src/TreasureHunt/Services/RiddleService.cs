using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Infrastructure;
using TreasureHunt.Services.Models;

namespace TreasureHunt.Services
{
    public class RiddleService
    {
        private RiddleRepository _riddlerepository;

        public RiddleService(RiddleRepository riddlerepository)
        {
            _riddlerepository = riddlerepository;
        }

        public ICollection<RiddleDTO>GetRiddleList()
        {
            return (from r in _riddlerepository.List()
                    select new RiddleDTO
                    {
                        Clue = r.Clue,
                        Answer = r.Answer,
                        IsAnswered = r.IsAnswered
                    }).ToList();
        }
    }
}
