using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using TreasureHunt.Models;

namespace TreasureHunt.Controllers
{
    [Produces("application/json")]
    [Route("api/teamhunts")]
    public class TeamHuntsController : Controller
    {
        private ApplicationDbContext _context;

        public TeamHuntsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamHunts
        [HttpGet]
        public IEnumerable<HuntTeam> GetHuntTeams()
        {
            return _context.HuntTeams;
        }

        // GET: api/TeamHunts/5
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

        // PUT: api/TeamHunts/5
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

        // POST: api/TeamHunts
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

        // DELETE: api/TeamHunts/5
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
    }
}