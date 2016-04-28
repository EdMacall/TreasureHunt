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
    [Route("api/teamhunts")]
    public class TeamHuntsController : Controller
    {
        private HuntTeamService _huntteamservice;

        public TeamHuntsController(HuntTeamService huntteamservice)
        {
            _huntteamservice = huntteamservice;
        }

        /*
        // GET: api/TeamHunts
        [HttpGet]
        public IEnumerable<HuntTeam> GetHuntTeams()
        {
            return _huntteamservice.HuntTeams;
        }
        */

        // GET: api/TeamHunts/5
        [HttpGet("{id}", Name = "GetTeamHunts")]
        public IActionResult GetHuntTeam([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            HuntDTO huntdto = _huntteamservice.GetTeamHuntList(id);

            if (huntdto == null)
            {
                return HttpNotFound();
            }

            return Ok(huntdto);
        }

        /*
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

            _huntteamservice.Entry(huntTeam).State = EntityState.Modified;

            try
            {
                _huntteamservice.SaveChanges();
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

            _huntteamservice.HuntTeams.Add(huntTeam);
            try
            {
                _huntteamservice.SaveChanges();
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

            HuntTeam huntTeam = _huntteamservice.HuntTeams.Single(m => m.HuntId == id);
            if (huntTeam == null)
            {
                return HttpNotFound();
            }

            _huntteamservice.HuntTeams.Remove(huntTeam);
            _huntteamservice.SaveChanges();

            return Ok(huntTeam);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _huntteamservice.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HuntTeamExists(int id)
        {
            return _huntteamservice.HuntTeams.Count(e => e.HuntId == id) > 0;
        }
        */
    }
}