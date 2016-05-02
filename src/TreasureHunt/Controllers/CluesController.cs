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
    public class CluesController : Controller
    {
        private ClueService _clueservice;

        public CluesController(ClueService clueservice)
        {
            _clueservice = clueservice;
        }

        // GET: api/Hunts
        [HttpGet]
        public ICollection<ClueDTO> GetHunt()
        {
            return _clueservice.GetClueList().ToList();
        }

        // GET: api/Clues/5
        [HttpGet("{id}", Name = "GetClue")]
        public IActionResult GetClue([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            ClueDTO cluedto = _clueservice.GetClue(id);

            if (cluedto == null)
            {
                return HttpNotFound();
            }

            return Ok(cluedto);
        }

        /*
        // PUT: api/Clues/5
        [HttpPut("{id}")]
        public IActionResult PutClue(int id, [FromBody] Clue clue)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            if (id != clue.Id)
            {
                return HttpBadRequest();
            }

            _context.Entry(clue).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClueExists(id))
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

        // POST: api/Clues
        [HttpPost]
        public IActionResult PostClue([FromBody] Clue clue)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            _context.Clues.Add(clue);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ClueExists(clue.Id))
                {
                    return new HttpStatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("GetClue", new { id = clue.Id }, clue);
        }

        // DELETE: api/Clues/5
        [HttpDelete("{id}")]
        public IActionResult DeleteClue(int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            Clue clue = _context.Clues.Single(m => m.Id == id);
            if (clue == null)
            {
                return HttpNotFound();
            }

            _context.Clues.Remove(clue);
            _context.SaveChanges();

            return Ok(clue);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClueExists(int id)
        {
            return _context.Clues.Count(e => e.Id == id) > 0;
        }
        */
    }
}