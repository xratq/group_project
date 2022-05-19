using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AudiencesController : ControllerBase
    {
        private readonly TodoContext _context;

        public AudiencesController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/Audiences
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Audience>>> GetAudience()
        {
          if (_context.Audience == null)
          {
              return NotFound();
          }
            return await _context.Audience.ToListAsync();
        }

        // GET: api/Audiences/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Audience>> GetAudience(int id)
        {
          if (_context.Audience == null)
          {
              return NotFound();
          }
            var audience = await _context.Audience.FindAsync(id);

            if (audience == null)
            {
                return NotFound();
            }

            return audience;
        }

        // PUT: api/Audiences/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAudience(int id, Audience audience)
        {
            if (id != audience.ID)
            {
                return BadRequest();
            }

            _context.Entry(audience).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AudienceExists(id))
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

        // POST: api/Audiences
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Audience>> PostAudience(Audience audience)
        {
          if (_context.Audience == null)
          {
              return Problem("Entity set 'TodoContext.Audience'  is null.");
          }
            _context.Audience.Add(audience);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAudience", new { id = audience.ID }, audience);
        }

        // DELETE: api/Audiences/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAudience(int id)
        {
            if (_context.Audience == null)
            {
                return NotFound();
            }
            var audience = await _context.Audience.FindAsync(id);
            if (audience == null)
            {
                return NotFound();
            }

            _context.Audience.Remove(audience);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AudienceExists(int id)
        {
            return (_context.Audience?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
