using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using easy_tickets.Data;
using easy_tickets.DataModels;
using Marten;

namespace easy_tickets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IDocumentStore _documentStore;

        public ActsController(ApplicationDbContext context, IDocumentStore documentStore)
        {
            _context = context;
            _documentStore = documentStore;
        }

        // GET: api/Acts
        [HttpGet]
        public IEnumerable<Act> GetActs()
        {
            return _context.Acts;
        }

        // GET: api/Acts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var act = await _context.Acts.FindAsync(id);

            if (act == null)
            {
                return NotFound();
            }

            using (var session = _documentStore.OpenSession())
            {
                var visited = new ActVisited()
                {
                    ActID = act.ActID,
                    Name = act.Name,
                    VisitTime = DateTime.Now
                };

                session.Events.Append("act", visited);
                session.SaveChanges();
            }

            return Ok(act);
        }

        // PUT: api/Acts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAct([FromRoute] int id, [FromBody] Act act)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != act.ActID)
            {
                return BadRequest();
            }

            _context.Entry(act).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Acts
        [HttpPost]
        public async Task<IActionResult> PostAct([FromBody] Act act)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Acts.Add(act);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAct", new { id = act.ActID }, act);
        }

        // DELETE: api/Acts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var act = await _context.Acts.FindAsync(id);
            if (act == null)
            {
                return NotFound();
            }

            _context.Acts.Remove(act);
            await _context.SaveChangesAsync();

            return Ok(act);
        }

        private bool ActExists(int id)
        {
            return _context.Acts.Any(e => e.ActID == id);
        }
    }
}