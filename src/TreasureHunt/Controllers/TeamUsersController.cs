using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using TreasureHunt.Models;
using TreasureHunt.Services;

namespace TreasureHunt.Controllers
{
    [Produces("application/json")]
    [Route("api/TeamUsers")]
    public class TeamUsersController : Controller
    {
        private TeamService _teamService;

        public TeamUsersController(TeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public ICollection<TeamUser> GetTeamUsers()
        {
            return _teamService.GetTeamUsers();
        }

        [HttpPost]
        public IActionResult JoinTeam([FromBody]string teamName)
        {
            if(teamName != null) { 

                _teamService.JoinTeam(teamName, User.Identity.Name);

                return Ok();
            }

            return HttpBadRequest();
        }

        //// DELETE: api/TeamUsers/5
        //[HttpDelete("{id}")]
        //public IActionResult DeleteTeamUser(int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return HttpBadRequest(ModelState);
        //    }

        //    TeamUser teamUser = _context.TeamUsers.Single(m => m.TeamId == id);
        //    if (teamUser == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    _context.TeamUsers.Remove(teamUser);
        //    _context.SaveChanges();

        //    return Ok(teamUser);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        _context.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool TeamUserExists(int id)
        //{
        //    return _context.TeamUsers.Count(e => e.TeamId == id) > 0;
        //}
    }
}