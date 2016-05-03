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
    public class HuntsController : Controller
    {
        private HuntService _huntservice;

        public HuntsController(HuntService huntservice)
        {
            _huntservice = huntservice;
        }

        // GET: api/Hunts
        [HttpGet]
        public ICollection<HuntDTO> GetHunt()
        {
            return _huntservice.GetHuntList().ToList();
        }

        // GET: api/Hunts/5
        [HttpGet("{id}", Name = "GetHunt")]
        public IActionResult GetHunt([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            HuntDTO huntdto = _huntservice.GetHunt(id);

            if (huntdto == null)
            {
                return HttpNotFound();
            }

            return Ok(huntdto);
        }

        [HttpPost]
        public IActionResult Post([FromBody]HuntDTO huntdto)
        {
            if (ModelState.IsValid)
            {
                _huntservice.AddHuntList(huntdto);

                return Ok();
            }
            else {
                return HttpBadRequest(ModelState);
            }
        }

        //[HttpGet("{id}/teams")]
        public IActionResult GetTeams(int id)
        //{
            if (!ModelState.IsValid)
            {
                return HttpBadRequest(ModelState);
            }

            HuntDTO huntdto = _huntservice.GetHunt(id);

            if (huntdto == null)
            {
                return HttpNotFound();
            }

            ICollection<TeamDTO> teamsdto = huntdto.Teams;

            return Ok(teamsdto);

        /*
         // GET: api/Hunts/5
         [HttpGet("{id}", Name = "GetHunt")]
         public IActionResult GetHunt([FromRoute] int id)
         {
             if (!ModelState.IsValid)
             {
                 return HttpBadRequest(ModelState);
             }

             Hunt hunt = _context.Hunts.Single(m => m.Id == id);

             if (hunt == null)
             {
                 return HttpNotFound();
             }

             return Ok(hunt);
         }

         // PUT: api/Hunts/5
         [HttpPut("{id}")]
         public IActionResult PutHunt(int id, [FromBody] Hunt hunt)
         {
             if (!ModelState.IsValid)
             {
                 return HttpBadRequest(ModelState);
             }

             if (id != hunt.Id)
             {
                 return HttpBadRequest();
             }

             _context.Entry(hunt).State = EntityState.Modified;

             try
             {
                 _context.SaveChanges();
             }
             catch (DbUpdateConcurrencyException)
             {
                 if (!HuntExists(id))
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

         // POST: api/Hunts
         [HttpPost]
         public IActionResult PostHunt([FromBody] Hunt hunt)
         {
             if (!ModelState.IsValid)
             {
                 return HttpBadRequest(ModelState);
             }

             _context.Hunts.Add(hunt);
             try
             {
                 _context.SaveChanges();
             }
             catch (DbUpdateException)
             {
                 if (HuntExists(hunt.Id))
                 {
                     return new HttpStatusCodeResult(StatusCodes.Status409Conflict);
                 }
                 else
                 {
                     throw;
                 }
             }

             return CreatedAtRoute("GetHunt", new { id = hunt.Id }, hunt);
         }

         // DELETE: api/Hunts/5
         [HttpDelete("{id}")]
         public IActionResult DeleteHunt(int id)
         {
             if (!ModelState.IsValid)
             {
                 return HttpBadRequest(ModelState);
             }

             Hunt hunt = _context.Hunts.Single(m => m.Id == id);
             if (hunt == null)
             {
                 return HttpNotFound();
             }

             _context.Hunts.Remove(hunt);
             _context.SaveChanges();

             return Ok(hunt);
         }

         protected override void Dispose(bool disposing)
         {
             if (disposing)
             {
                 _context.Dispose();
             }
             base.Dispose(disposing);
         }

         private bool HuntExists(int id)
         {
             return _context.Hunts.Count(e => e.Id == id) > 0;
         }
         */
    }
}