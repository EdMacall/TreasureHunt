using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Infrastructure;

namespace TreasureHunt.Services.Models
{
    // phasing this one out...
    public class HuntRiddleService
    {
        private HuntRiddleRepository _huntriddlerepository;

        public HuntRiddleService(HuntRiddleRepository huntriddlerepository)
        {
            _huntriddlerepository = huntriddlerepository;
        }

        public ICollection<HuntRiddleDTO> GetHuntRiddleList()
        {
            return (from r in _huntriddlerepository.List()
                    select new HuntRiddleDTO
                    {
                        // TeamName =
                    }).ToList();
        }
    }
}
