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
    public class Educational_buildingController : ControllerBase
    {
        private readonly TodoContext _context;

        public Educational_buildingController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/Educational_building
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Educational_building>>> GetEducational_building()
        {
          if (_context.Educational_building == null)
          {
              return NotFound();
          }
            return await _context.Educational_building.ToListAsync();
        }

        // GET: api/Educational_building/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Educational_building>> GetEducational_building(int id)
        {
          if (_context.Educational_building == null)
          {
              return NotFound();
          }
            var educational_building = await _context.Educational_building.FindAsync(id);

            if (educational_building == null)
            {
                return NotFound();
            }

            return educational_building;
        }

        // PUT: api/Educational_building/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEducational_building(int id, Educational_building educational_building)
        {
            if (id != educational_building.ID)
            {
                return BadRequest();
            }

            _context.Entry(educational_building).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Educational_buildingExists(id))
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

        // POST: api/Educational_building
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Educational_building>> PostEducational_building(Educational_building educational_building)
        {
          if (_context.Educational_building == null)
          {
              return Problem("Entity set 'TodoContext.Educational_building'  is null.");
          }
            _context.Educational_building.Add(educational_building);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEducational_building", new { id = educational_building.ID }, educational_building);
        }

        // DELETE: api/Educational_building/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEducational_building(int id)
        {
            if (_context.Educational_building == null)
            {
                return NotFound();
            }
            var educational_building = await _context.Educational_building.FindAsync(id);
            if (educational_building == null)
            {
                return NotFound();
            }

            _context.Educational_building.Remove(educational_building);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Educational_buildingExists(int id)
        {
            return (_context.Educational_building?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
