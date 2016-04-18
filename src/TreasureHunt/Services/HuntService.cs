using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Infrastructure;
using TreasureHunt.Services.Models;

namespace TreasureHunt.Services
{
    public class HuntService
    {
        private HuntRepository _huntrepository;

        public HuntService(HuntRepository huntrepository)
        {
            _huntrepository = huntrepository;
        }

        public ICollection<HuntDTO> GetHuntList()
        {
            return (from h in _huntrepository.List()
                    select new HuntDTO
                    {
                        Name = h.Name
                    }).ToList();
        }
    }
}
