using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using TreasureHunt.Models;
using TreasureHunt.Services;
using TreasureHunt.Services.Models;

namespace TreasureHunt.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class HuntTeamsController : Controller
    {
        private HuntTeamService _huntteamservice;

        public HuntTeamsController(HuntTeamService huntteamservice)
        {
            _huntteamservice = huntteamservice;
        }

        // GET: api/Hunts
        [HttpGet]
        public ICollection<HuntTeamDTO> GetHunt()
        {
            return _huntteamservice.GetHuntTeamList().ToList();
        }

        // GET: api/Hunts/5
        [HttpGet("{id}", Name = "GetTeams")]
        public IActionResult GetTeams([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            // ICollection<HuntTeamDTO> huntteamdto = _huntteamservice.GetHuntTeamList(id);
            ICollection<TeamDTO> huntteamdto = _huntteamservice.GetHuntTeamList(id);

            // Hunt hunt = _huntservice.Hunts.Single(m => m.Id == id);

            if (huntteamdto == null)
            {
                return HttpNotFound();
            }

            return Ok(huntteamdto);
        }

        /*
        private ApplicationDbContext _context;

        public HuntTeamsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/HuntTeams
        [HttpGet]
        public IEnumerable<HuntTeam> GetHuntTeams()
        {
            return _context.HuntTeams;
        }

        // GET: api/HuntTeams/5
        [HttpGet("{id}", Name = "GetHuntTeam")]
        public IActionResult GetHuntTeam([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            HuntTeam huntTeam = _context.HuntTeams.Single(m => m.HuntId == id);

            if (huntTeam == null)
            {
                return HttpNotFound();
            }

            return Ok(huntTeam);
        }

        // PUT: api/HuntTeams/5
        [HttpPut("{id}")]
        public IActionResult PutHuntTeam(int id, [FromBody] HuntTeam huntTeam)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            if (id != huntTeam.HuntId)
            {
                return HttpBadRequest();
            }

            _context.Entry(huntTeam).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HuntTeamExists(id))
                {
                    return HttpNotFound();
                }
                else
                {
                    throw;
                }
            }

            return new HttpStatusCodeResult(StatusCodes.Status204NoContent);
        }

        // POST: api/HuntTeams
        [HttpPost]
        public IActionResult PostHuntTeam([FromBody] HuntTeam huntTeam)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            _context.HuntTeams.Add(huntTeam);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (HuntTeamExists(huntTeam.HuntId))
                {
                    return new HttpStatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("GetHuntTeam", new { id = huntTeam.HuntId }, huntTeam);
        }

        // DELETE: api/HuntTeams/5
        [HttpDelete("{id}")]
        public IActionResult DeleteHuntTeam(int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            HuntTeam huntTeam = _context.HuntTeams.Single(m => m.HuntId == id);
            if (huntTeam == null)
            {
                return HttpNotFound();
            }

            _context.HuntTeams.Remove(huntTeam);
            _context.SaveChanges();

            return Ok(huntTeam);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HuntTeamExists(int id)
        {
            return _context.HuntTeams.Count(e => e.HuntId == id) > 0;
        }
        */
    }
}