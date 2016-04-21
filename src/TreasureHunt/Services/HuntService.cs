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

        public HuntService(HuntRepository huntrepository)
        {
            _huntrepository = huntrepository;
        }

        public ICollection<HuntDTO> GetHuntList()
        {
            return (from h in _huntrepository.List()
                    select new HuntDTO
                    {
                        Id = h.Id,
                        Name = h.Name
                    }).ToList();
        }

        public HuntDTO GetHunt(int id)
        {
            // return _huntrepository.First(b => b.Id ==id);

            Hunt hunt = _huntrepository.List().FirstOrDefault(m => m.Id == id);


            return new HuntDTO {Name = hunt.Name};
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
