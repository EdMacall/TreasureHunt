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
    public class RiddleService
    {
        private RiddleRepository _riddlerepository;

        public RiddleService(RiddleRepository riddlerepository)
        {
            _riddlerepository = riddlerepository;
        }

        public ICollection<RiddleDTO> GetRiddleList()
        {
            ICollection<RiddleDTO> riddledto = (from r in _riddlerepository.List()
                    select new RiddleDTO
                    {
                        Title = r.Title,
                        Clue = r.Clue,
                        Answer = r.Answer,
                        IsAnswered = r.IsAnswered,
                        // Completed = (r.IsAnswered) ? "Completed" : "Not Completed",
                        Completed = "Not Completed",
                        Points = r.Points                        
                    }).ToList();

            foreach(var r in riddledto)
            {
                if (r.IsAnswered)
                    r.Completed = "Completed";
            }

            return riddledto;
        }

        // I don't know if I can get the riddleId here either.
        public void CheckAnswer(int riddleId, string playersanswer)
        {

        }

        public void AddRiddlesList(RiddleDTO riddledto)
        {
           Riddle riddle = new Riddle
           {
               Clue = riddledto.Clue,
               Answer = riddledto.Answer,
               IsAnswered = riddledto.IsAnswered,
               Points = riddledto.Points
           };
            _riddlerepository.Add(riddle);
            _riddlerepository.SaveChanges();
        }
    }
}
