using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using TreasureHunt.Models;
using TreasureHunt.Services.Models;
using TreasureHunt.Services;

namespace TreasureHunt.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TeamsController : Controller
    {
        private TeamService _teamservice;

        public TeamsController(TeamService teamservice)
        {
            _teamservice = teamservice;
        }

        // GET: api/Riddles
        [HttpGet]
        public ICollection<TeamDTO> GetTeam()
        {
            return _teamservice.GetTeamList().ToList();
        }

        // GET: api/Teams/5
        [HttpGet("{id}", Name = "GetTeam")]
        public IActionResult GetHunt([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            TeamDTO teamdto = _teamservice.GetTeam(id);

            // Hunt hunt = _huntservice.Hunts.Single(m => m.Id == id);

            if (teamdto == null)
            {
                return HttpNotFound();
            }

            return Ok(teamdto);
        }

        [HttpPost("{huntId}")]
        public IActionResult Post(int huntId, [FromBody]TeamDTO teamdto)
        // public IActionResult Post(int huntId, [FromBody]Team team)
        {
            if (ModelState.IsValid)
            {
                // _teamservice.AddTeamList(team);

                // return Ok(_teamservice.AddHuntTeamList(huntId, teamdto));
                _teamservice.AddHuntTeamList(huntId, teamdto);
                return Ok();
            }
            else {
                return HttpBadRequest(ModelState);
            }
        }

        /*
        // GET: api/Teams/5
        [HttpGet("{id}", Name = "GetTeam")]
        public IActionResult GetTeam([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            Team team = _context.Teams.Single(m => m.Id == id);

            if (team == null)
            {
                return HttpNotFound();
            }

            return Ok(team);
        }

        // PUT: api/Teams/5
        [HttpPut("{id}")]
        public IActionResult PutTeam(int id, [FromBody] Team team)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            if (id != team.Id)
            {
                return HttpBadRequest();
            }

            _context.Entry(team).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamExists(id))
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

        // POST: api/Teams
        [HttpPost]
        public IActionResult PostTeam([FromBody] Team team)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            _context.Teams.Add(team);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (TeamExists(team.Id))
                {
                    return new HttpStatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("GetTeam", new { id = team.Id }, team);
        }

        // DELETE: api/Teams/5
        [HttpDelete("{id}")]
        public IActionResult DeleteTeam(int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            Team team = _context.Teams.Single(m => m.Id == id);
            if (team == null)
            {
                return HttpNotFound();
            }

            _context.Teams.Remove(team);
            _context.SaveChanges();

            return Ok(team);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TeamExists(int id)
        {
            return _context.Teams.Count(e => e.Id == id) > 0;
        }
        */
    }
}