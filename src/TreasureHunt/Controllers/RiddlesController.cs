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
    // phasing this one out...
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class RiddlesController : Controller
    {
        private RiddleService _riddleservice;

        public RiddlesController(RiddleService riddleservice)
        {
            _riddleservice = riddleservice;
        }

        // GET: api/Riddles
        [HttpGet]
        public ICollection<RiddleDTO> GetRiddle()
        {
            return _riddleservice.GetRiddleList().ToList();
        }

        // I don't know if I can get the riddle Id...
        // This needs to be a post to find out if the player's answer
        // matches the riddle's answer in the database
        [HttpPost("{riddleId}")]
        public IActionResult Post(int riddleId, [FromBody]string playersanswer)
        {
            if (ModelState.IsValid)
            {
                // _teamservice.AddTeamList(team);

                // return Ok(_teamservice.AddHuntTeamList(huntId, teamdto));
                _riddleservice.CheckAnswer(riddleId, playersanswer);
                return Ok();
            }
            else {
                return HttpBadRequest(ModelState);
            }
        }

        //// GET: api/Riddles/5
        //[HttpGet("{id}", Name = "GetRiddle")]
        //public IActionResult GetRiddle([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return HttpBadRequest(ModelState);
        //    }

        //    Riddle riddle = _context.Riddles.Single(m => m.Id == id);

        //    if (riddle == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return Ok(riddle);
        //}

        //// PUT: api/Riddles/5
        //[HttpPut("{id}")]
        //public IActionResult PutRiddle(int id, [FromBody] Riddle riddle)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return HttpBadRequest(ModelState);
        //    }

        //    if (id != riddle.Id)
        //    {
        //        return HttpBadRequest();
        //    }

        //    _context.Entry(riddle).State = EntityState.Modified;

        //    try
        //    {
        //        _context.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!RiddleExists(id))
        //        {
        //            return HttpNotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return new HttpStatusCodeResult(StatusCodes.Status204NoContent);
        //}

        //// POST: api/Riddles
        [HttpPost]
        public IActionResult Post([FromBody]RiddleDTO riddledto)
        {
            if (ModelState.IsValid)
            {
                _riddleservice.AddRiddlesList(riddledto);

                return Ok();
            }
            else {
                return HttpBadRequest(ModelState);
            }
        }
        //// DELETE: api/Riddles/5
        //[HttpDelete("{id}")]
        //public IActionResult DeleteRiddle(int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return HttpBadRequest(ModelState);
        //    }

        //    Riddle riddle = _context.Riddles.Single(m => m.Id == id);
        //    if (riddle == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    _context.Riddles.Remove(riddle);
        //    _context.SaveChanges();

        //    return Ok(riddle);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        _context.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool RiddleExists(int id)
        //{
        //    return _context.Riddles.Count(e => e.Id == id) > 0;
        //}

    }
}