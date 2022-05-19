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
    public class Software_listController : ControllerBase
    {
        private readonly TodoContext _context;

        public Software_listController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/Software_list
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Software_list>>> GetSoftware_list()
        {
          if (_context.Software_list == null)
          {
              return NotFound();
          }
            return await _context.Software_list.ToListAsync();
        }

        // GET: api/Software_list/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Software_list>> GetSoftware_list(int id)
        {
          if (_context.Software_list == null)
          {
              return NotFound();
          }
            var software_list = await _context.Software_list.FindAsync(id);

            if (software_list == null)
            {
                return NotFound();
            }

            return software_list;
        }

        // PUT: api/Software_list/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSoftware_list(int id, Software_list software_list)
        {
            if (id != software_list.ID)
            {
                return BadRequest();
            }

            _context.Entry(software_list).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Software_listExists(id))
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

        // POST: api/Software_list
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Software_list>> PostSoftware_list(Software_list software_list)
        {
          if (_context.Software_list == null)
          {
              return Problem("Entity set 'TodoContext.Software_list'  is null.");
          }
            _context.Software_list.Add(software_list);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSoftware_list", new { id = software_list.ID }, software_list);
        }

        // DELETE: api/Software_list/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSoftware_list(int id)
        {
            if (_context.Software_list == null)
            {
                return NotFound();
            }
            var software_list = await _context.Software_list.FindAsync(id);
            if (software_list == null)
            {
                return NotFound();
            }

            _context.Software_list.Remove(software_list);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Software_listExists(int id)
        {
            return (_context.Software_list?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
